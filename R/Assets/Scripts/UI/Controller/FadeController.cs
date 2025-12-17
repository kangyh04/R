using UnityEngine;

public class FadeController : MonoBehaviour
{
    [SerializeField]
    private FadeView fadeView;

    [SerializeField]
    private float fadeTime;

    public async void FadeInAsync()
    {
        await fadeView.Fade(0.0f, fadeTime, fadeTime);
    }

    public async void FadeOutAsync()
    {
        await fadeView.Fade(fadeTime, 0.0f, fadeTime);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.LogError("Fade In");
            FadeInAsync();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.LogError("Fade Out");
            FadeOutAsync();
        }
    }
}
