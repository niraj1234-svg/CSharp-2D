using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager1 : MonoBehaviour
{
    public void RestartGame()
    {
        // Resume game (important because we paused using Time.timeScale = 0)
        Time.timeScale = 1f;

        // Reset coins to 0 when starting a new game
        GameManager.instance.ResetCoins();

        // Load first level (Level 1)
        SceneManager.LoadScene(0);
    }
}