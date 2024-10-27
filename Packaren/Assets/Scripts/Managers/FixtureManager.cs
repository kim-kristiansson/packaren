using Assets.Scripts.UI;
using UnityEngine;

namespace Assets.Scripts.Managers {
    public class FixtureManager:MonoBehaviour
    {
        public Fixture fixture;
        private Fixture fixtureInstance;

        private void OnEnable()
        {
            UIManager.OnGenerateClick += GenerateFixture;
        }

        private void OnDisable()
        {
            UIManager.OnGenerateClick -= GenerateFixture;
        }

        public void GenerateFixture()
        {
            if(fixtureInstance == null)
            {
                fixtureInstance = Instantiate(fixture, new Vector3(0, 0, 0), Quaternion.identity);
                AppStateManager.Instance.IsComponentGenerated = true;
                Debug.Log("Fixture generated");

                fixtureInstance.Initialize();
            }
            else{
                Debug.Log("Fixture already exists");
            }
        }
    }
}
