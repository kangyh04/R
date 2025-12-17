using UnityEngine;

public class UICamera : MonoBehaviour
{
    private static UICamera instance;
    public static UICamera Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
