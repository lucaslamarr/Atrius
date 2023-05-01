using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string _nextLevel;
    [SerializeField] private ScreenFade _screenFade;

    private AudioSource _audioSource;

    private void Awake()
    {
        LockCursor();
        Invoke("UnlockCursor", 3f);

        _audioSource = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        LockCursor();
        _screenFade.Fade(false);
        _audioSource.Play();
        Invoke("ChangeScene", 5f);
    }

    public void ExitGame()
    {
        LockCursor();
        _screenFade.Fade(false);
        Invoke("Shutdown", 5f);
    }

    private void ChangeScene()
    {
        UnlockCursor();
        Cursor.visible = false;
        SceneManager.LoadScene(_nextLevel);
    }

    private void Shutdown()
    {
        Application.Quit();
    }

    private void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void OpenTwitter()
    {
        Application.OpenURL("http://www.twitter.com/lucaslamarr");
    }
}
