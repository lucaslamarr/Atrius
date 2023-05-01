using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalLevel : MonoBehaviour
{
    [SerializeField] private ScreenFade _screenFade;

    void Start()
    {
        Invoke("FadeOut", 15);
    }

    private void FadeOut()
    {
        _screenFade.Fade(false);
        Invoke("AutoQuitGame", 5);
    }

    private void AutoQuitGame()
    {
        Application.Quit();
    }
}
