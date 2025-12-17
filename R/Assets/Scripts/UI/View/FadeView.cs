using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class FadeView : MonoBehaviour
{
    [SerializeField]
    private Image fadeImage;

    [SerializeField]
    private float fadeTime;

    public UniTask FadeIn()
    {
        Fade(0.0f, fadeTime);
    }

    public void FadeOut()
    {
        Fade(fadeTime, 0.0f);
    }

    private void Fade(float startVelue, float endValue)
    {
        var fade = startVelue;
        var sign = Mathf.Sign(endValue - startVelue);
        var color = fadeImage.color;

        while (endValue - fade <= Mathf.Epsilon)
        {
            var deltaValue = Time.deltaTime;
            if (endValue - fade <= deltaValue)
            {
                deltaValue = endValue - fade;
            }
            fade += deltaValue * sign;
            var alpha = (fadeTime - fade) / fadeTime;
            fadeImage.color = new Color(color.r, color.g, color.b, alpha);
        }

        var destAlpha = (fadeTime - endValue) / fadeTime;
        fadeImage.color = new Color(color.r, color.g, color.b, destAlpha);
    }
}
