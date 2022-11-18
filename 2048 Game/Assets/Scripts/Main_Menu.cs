using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public string levelToLoad;

    public GameObject controlsWindow;
    public GameObject creditsWindow;

    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void OpenControlsWindow()
    {
        controlsWindow.SetActive(true);
    }

    public void OpenCreditsWindow()
    {
        creditsWindow.SetActive(true);
    }

    public void CloseControlsSWindow()
    {
        controlsWindow.SetActive(false);
    }

    public void CloseCreditsSWindow()
    {
        creditsWindow.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}