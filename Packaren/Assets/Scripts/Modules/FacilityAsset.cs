using System;
using UnityEngine;

public abstract class FacilityAsset : MonoBehaviour
{
    public float weight;

    public float Height => CalculateHeight();
    public float Width => CalculateWidth();

    private Renderer objectRenderer;

    public Vector3 BottomPosition => CalculateBottomPosition();
    public Vector3 TopPosition => CalculateTopPosition();
    public Vector3 CenterPosition => CalculateCenterPosition();

    private Vector3 CalculateCenterPosition()
    {
        return objectRenderer != null ? objectRenderer.bounds.center : transform.position;
    }

    private Vector3 CalculateTopPosition()
    {
        return objectRenderer != null ? objectRenderer.bounds.max : transform.position;
    }

    private Vector3 CalculateBottomPosition()
    {
        return objectRenderer != null ? objectRenderer.bounds.min : transform.position;
    }

    protected virtual void Awake()
    {
        objectRenderer = GetComponent<Renderer>();

        if (objectRenderer == null)
        {
            Debug.LogWarning("Renderer not found");
        }
    }

    private float CalculateWidth()
    {
        return objectRenderer != null ? objectRenderer.bounds.size.x : 0;
    }

    private float CalculateHeight()
    {
        return objectRenderer != null ? objectRenderer.bounds.size.y : 0;
    }

    public T StackObjectOnTop<T>(T newObject) where T : FacilityAsset
    {
        T newObjectInstance = Instantiate(newObject);

        float newObjectBottomOffset = newObjectInstance.Height / 2;

        Vector3 newObjectPosition = new(this.CenterPosition.x, this.TopPosition.y + newObjectBottomOffset, this.CenterPosition.z);

        newObjectInstance.transform.position = newObjectPosition;

        newObjectInstance.transform.SetParent(this.transform);

        return newObjectInstance;
    }
}