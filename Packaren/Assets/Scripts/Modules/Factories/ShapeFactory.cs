using UnityEngine;

public class ShapeFactory : MonoBehaviour
{
    [SerializeField] private CylinderDetail cylinderDetail;
    [SerializeField] private CuboidDetail sphereDetail;

    public CylinderDetail CreateCylinder(float diameter, float height)
    {
        CylinderDetail newCylinder = Instantiate(cylinderDetail);

        newCylinder.SetDimensions(diameter, height);

        return newCylinder;
    }

    public CuboidDetail CreateCuboid(float width, float height, float depth)
    {
        CuboidDetail newCuboid = Instantiate(sphereDetail);

        newCuboid.SetDimensions(width, height, depth);

        return newCuboid;
    }
}
