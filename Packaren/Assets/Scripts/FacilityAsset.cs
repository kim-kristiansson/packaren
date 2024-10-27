using System;
using UnityEngine;

public abstract class FacilityAsset : PhysicalObject
{
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