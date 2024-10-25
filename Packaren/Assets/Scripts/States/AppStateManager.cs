using UnityEngine;

public class AppStateManager : MonoBehaviour
{
    public static AppStateManager Instance;
    private bool isComponentGenerated = false;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    public bool IsComponentGenerated
    {
        get {return isComponentGenerated;}
        set {isComponentGenerated = value;}
    }
}
