using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public string levelToLoad;

    public GameObject controlsWindow;
    public GameObject creditsWindow;
    [SerializeField] private AudioSource buttonclickopen;
    [SerializeField] private AudioSource buttonclickclose;

    public void StartGame()
    {
        buttonclickopen.Play();
        SceneManager.LoadScene(levelToLoad);
    }

    public void OpenControlsWindow()
    {
        buttonclickopen.Play();
        controlsWindow.SetActive(true);
    }

    public void OpenCreditsWindow()
    {
        buttonclickopen.Play();
        creditsWindow.SetActive(true);
    }

    public void CloseControlsSWindow()
    {
        buttonclickclose.Play();
        controlsWindow.SetActive(false);
    }

    public void CloseCreditsSWindow()
    {
        buttonclickclose.Play();
        creditsWindow.SetActive(false);
    }

    public void QuitGame()
    {
        buttonclickclose.Play();
        Application.Quit();
    }
}