using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShapeSpawner : MonoBehaviour
{
    [SerializeField] private TMP_InputField heightInputField;
    [SerializeField] private TMP_InputField widthInputField;
    [SerializeField] private TMP_InputField depthInputField;
    [SerializeField] private TMP_InputField diameterInputField;
    [SerializeField] private TMP_Dropdown shapeDropdown;
    [SerializeField] private Button spawnButton;

    private ShapeFactory shapeFactory;

    private void Start()
    {
        shapeFactory = GetComponent<ShapeFactory>();
        spawnButton.onClick.AddListener(SpawnShape);
        shapeDropdown.onValueChanged.AddListener(delegate { UpdateUIFields(); });

        UpdateUIFields();
    }

    private void UpdateUIFields()
    {
        string shapeType = shapeDropdown.options[shapeDropdown.value].text;

        heightInputField.gameObject.SetActive(true);
        widthInputField.gameObject.SetActive(shapeType == "Cylinder");
        depthInputField.gameObject.SetActive(shapeType == "Cuboid");
        diameterInputField.gameObject.SetActive(shapeType == "Cylinder");
    }

    private void SpawnShape()
    {
        string shapeType = shapeDropdown.options[shapeDropdown.value].text;

        if (shapeType == "Cylinder" && float.TryParse(heightInputField.text, out float height) && float.TryParse(diameterInputField.text, out float diameter))
        {
            shapeFactory.CreateCylinder(height, diameter);
        }
        else if (shapeType == "Cuboid" && float.TryParse(widthInputField.text, out float width) && float.TryParse(heightInputField.text, out height) && float.TryParse(depthInputField.text, out float depth))
        {
            shapeFactory.CreateCuboid(width, height, depth);
        }
    }
}