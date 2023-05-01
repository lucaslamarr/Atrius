using UnityEngine;

public class ScreenFade : MonoBehaviour
{
    private Animation _animation;
    [SerializeField] private bool _fadeInOut = true;
    [SerializeField] private AnimationClip _fadeIn;
    [SerializeField] private AnimationClip _fadeOut;

    private void Awake()
    {
        _animation = GetComponent<Animation>();
    }

    private void Start()
    {
        Fade(_fadeInOut);
    }

    public void Fade(bool fadeInOut)
    {
        if (fadeInOut)
        {
            _animation.clip = _fadeIn;
        }
        else
        {
            _animation.clip = _fadeOut;
        }
        _animation.Play();
    }
}
