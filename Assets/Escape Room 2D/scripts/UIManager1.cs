using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager1 : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1f; // ?? IMPORTANT

        if (GameManager.instance != null)
        {
            GameManager.instance.ResetCoins();
        }

        SceneManager.LoadScene(1); // load Level1
    }

    public void MainMenu()
    {
        Time.timeScale = 1f; // ?? IMPORTANT
        SceneManager.LoadScene(0);
    }
}