using UnityEngine;

namespace Assets.Scripts.UI {
    public class UIManager : MonoBehaviour
    {
        public delegate void OnGenerate();
        public static event OnGenerate OnGenerateClick;

        public void GenerateButtonClicked()
        {
            OnGenerateClick?.Invoke();
        }
    }
}
