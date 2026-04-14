using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject winPanel;
    public GameObject gameOverPanel;

    public int coins = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        coins = SaveSystem.LoadCoins(); // fixed name
    }

    public void AddCoin(int amount)
    {
        coins += amount;
    }

    public void ResetCoins()
    {
        coins = 0;
    }

    public void WinGame()
    {
        Time.timeScale = 0f;

        if (winPanel != null)
            winPanel.SetActive(true);

        int level = SceneManager.GetActiveScene().buildIndex;

        SaveSystem.SaveGame(coins, level + 1); // fixed name
    }

    public void GameOver()
    {
        Time.timeScale = 0f;

        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;

        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }

    public void ContinueGame()
    {
        int savedLevel = SaveSystem.LoadLevel(); // fixed name
        SceneManager.LoadScene(savedLevel);
    }
}