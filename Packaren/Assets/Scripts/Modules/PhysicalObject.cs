using UnityEngine;

public abstract class PhysicalObject : MonoBehaviour
{    
    [SerializeField] private float weight;

    private Renderer objectRenderer;

    public Vector3 CenterPosition => CalculateCenterPosition();
    public Vector3 BottomPosition => CalculateBottomPosition();
    public Vector3 TopPosition => CalculateTopPosition();
    public float Height => CalculateHeight();
    public float Width => CalculateWidth();

    protected virtual void Awake()
    {
        objectRenderer = GetComponent<Renderer>();

        if (objectRenderer == null)
        {
            Debug.LogWarning("Renderer not found");
        }
    }

    public virtual void Initialize(bool useWeight = true)
    {
        if (useWeight)
        {
            Debug.Log($"Weight: {weight}");
        }
    }

    private Vector3 CalculateTopPosition() => objectRenderer != null ? objectRenderer.bounds.max : transform.position;

    private Vector3 CalculateBottomPosition() => objectRenderer != null ? objectRenderer.bounds.min : transform.position;

    private Vector3 CalculateCenterPosition() => objectRenderer != null ? objectRenderer.bounds.center : transform.position;

    private float CalculateWidth() => objectRenderer != null ? objectRenderer.bounds.size.x : 0;

    private float CalculateHeight() => objectRenderer != null ? objectRenderer.bounds.size.y : 0;
}