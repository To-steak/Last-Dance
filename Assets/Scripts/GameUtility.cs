using UnityEngine;

public class GameUtility : MonoBehaviour
{
    private static GameUtility _instance;
    
    public static GameUtility INSTANCE
    {
        get => _instance;
    }

    void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Escape()
    {
        Cursor.visible = !Cursor.visible;
        Cursor.lockState = Cursor.visible ? CursorLockMode.None : CursorLockMode.Locked;
        print("escape");
    }
}
