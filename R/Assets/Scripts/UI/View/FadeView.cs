using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class FadeView : MonoBehaviour
{
    [SerializeField]
    private Image fadeImage;

    public async UniTask Fade(float startVelue, float endValue, float fadeTime)
    {
        var fade = startVelue;
        var sign = Mathf.Sign(endValue - startVelue);
        var color = fadeImage.color;

        while ((endValue - fade) * sign >= Mathf.Epsilon)
        {
            var deltaValue = Time.deltaTime;
            fade += deltaValue * sign;
            var alpha = (fadeTime - fade) / fadeTime;
            fadeImage.color = new Color(color.r, color.g, color.b, alpha);
            await UniTask.NextFrame();
        }

        var destAlpha = (fadeTime - endValue) / fadeTime;
        fadeImage.color = new Color(color.r, color.g, color.b, destAlpha);
    }
}
