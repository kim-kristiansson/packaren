using Assets.Scripts.UI;
using UnityEngine;

namespace Assets.Scripts.Managers {
    public class FixtureManager:MonoBehaviour
    {
        public GameObject fixturePrefab;
        private GameObject fixtureInstance;

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
                fixtureInstance = Instantiate(fixturePrefab, new Vector3(0, 0, 0), Quaternion.identity);
                AppStateManager.Instance.IsComponentGenerated = true;
                Debug.Log("Fixture generated");
            }
            else{
                Debug.Log("Fixture already exists");
            }
        }
    }
}
