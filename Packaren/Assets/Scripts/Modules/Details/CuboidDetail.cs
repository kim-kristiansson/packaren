using UnityEngine;

public class CuboidDetail : PhysicalObject
{
    public void SetDimensions(float width, float height, float depth)
    {
        transform.localScale = new Vector3(width, height, depth);
    }
}