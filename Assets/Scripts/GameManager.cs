using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            StartCoroutine("ForceQuitGame");
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            StopCoroutine("ForceQuitGame");
        }
    }

    private IEnumerator ForceQuitGame()
    {
        yield return new WaitForSeconds(3f);
        Application.Quit();
    }
}
