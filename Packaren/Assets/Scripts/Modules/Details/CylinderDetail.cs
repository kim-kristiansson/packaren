using UnityEngine;

public class CylinderDetail : PhysicalObject
{
    public void SetDimensions(float diameter, float height)
    {
        transform.localScale = new Vector3(diameter, height / 2, diameter);
    }
}