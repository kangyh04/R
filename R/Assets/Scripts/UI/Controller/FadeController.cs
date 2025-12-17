using Cysharp.Threading.Tasks;
using UnityEngine;

public class FadeController : MonoBehaviour
{
    private static FadeController instance;
    public static FadeController Instance
    {
        get
        {
            return instance;
        }
    }

    [SerializeField]
    private FadeView fadeView;

    [SerializeField]
    private float fadeTime;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public async UniTask FadeInAsync()
    {
        await fadeView.Fade(0.0f, fadeTime, fadeTime);
    }

    public async UniTask FadeOutAsync()
    {
        await fadeView.Fade(fadeTime, 0.0f, fadeTime);
    }
}
