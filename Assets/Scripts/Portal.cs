using UnityEngine.SceneManagement;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private string _nextSceneName;
    [SerializeField] private ScreenFade _screenFade;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _screenFade.Fade(false);
            _audioSource.Play();
            Destroy(collision.gameObject);
            Invoke("ChangeScene", 5f);
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(_nextSceneName);
    }
}
