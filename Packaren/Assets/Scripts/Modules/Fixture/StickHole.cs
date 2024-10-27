using UnityEngine;

namespace Assets.Scripts.Modules.Fixture
{
    public class StickHole : FacilityAsset
    {
        [SerializeField] private FixtureStick fixtureStick;
        private FixtureStick fixtureStickInstance;

        public void SpawnStick()
        {
            if(fixtureStickInstance == null)
            {
                fixtureStickInstance = this.StackObjectOnTop<FixtureStick>(fixtureStick);
            }
            else{
                Debug.Log("Stick already exists");
            }
        }

        public FixtureStick GetStick()
        {
            return fixtureStickInstance;
        }
    }
}