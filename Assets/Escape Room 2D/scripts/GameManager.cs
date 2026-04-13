using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Winpanel;
    public GameObject gameOverPanel;
    public static GameManager instance;
    public int coin = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { 
            Destroy(gameObject);
        }
    }
    public void AddCoin(int amount)
    {
        coin += amount;
    }
    public void ResetCoins()
    {
        coin = 0;
    }

    public void Wingame()
    {
        Time.timeScale = 0f;
        Winpanel.SetActive(true);
    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
    }
    public void Nextlevel()
    {
        Time.timeScale = 1f;
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }
   
}
