using System.Collections.Generic;
using Assets.Scripts.Modules.Fixture;

public class Fixture : FacilityAsset
{
    public List<StickHole> ringHoles;
    public List<StickHole> plateHoles;

    public override void Initialize(bool useRings = false)
    {
        base.Initialize();
        if (useRings)
        {
            SpawnSticks(ringHoles);
        }
        else
        {
            SpawnSticks(plateHoles);
        }
    }

    private void SpawnSticks(List<StickHole> holes)
    {
        foreach (var hole in holes)
        {
            hole.SpawnStick();
        }
    }
}