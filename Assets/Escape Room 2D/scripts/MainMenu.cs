using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.ResetCoins();
        }

        SceneManager.LoadScene(1);
    }

    public void ContinueGame()
    {
        int savedLevel = SaveSystem.LoadLevel();
        SceneManager.LoadScene(savedLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}