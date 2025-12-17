using Cysharp.Threading.Tasks;
using UnityEngine;

public class WorldInitializer : MonoBehaviour
{
    private static WorldInitializer instance;
    public static WorldInitializer Instance
    {
        get
        {
            if (instance == null)
            {
                var go = GameObject.Find("WorldInitializer");
                if (go == null)
                {
                    go = new GameObject("WorldInitializer");
                    go.AddComponent<WorldInitializer>();
                }
                instance = go.GetComponent<WorldInitializer>();
            }
            return instance;
        }
    }

    public async UniTask InitializeWorld()
    {

    }
}
