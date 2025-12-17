using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private static SceneController instance;

    private void Awake()
    {
        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    public static async void ChangeScene(string sceneName)
    {
        await FadeController.Instance.FadeOutAsync();
        await SceneManager.LoadSceneAsync(sceneName);
        await WorldInitializer.Instance.InitializeWorld();
        await FadeController.Instance.FadeInAsync();
    }
}
