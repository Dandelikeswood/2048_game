using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject Controls_Window;

    [SerializeField] private AudioSource buttonclickopen;
    [SerializeField] private AudioSource buttonclickclose;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    void Paused()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    public void Resume()
    {
        buttonclickclose.Play();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    public void OpenControlsWindow()
    {
        buttonclickopen.Play();
        Controls_Window.SetActive(true);
    }

    public void CloseControlsWindow()
    {
        buttonclickclose.Play();
        Controls_Window.SetActive(false);
    }

    public void LoadMainMenu()
    {
        buttonclickclose.Play();
        Resume();
        SceneManager.LoadScene("Main_Menu");
    }
}
