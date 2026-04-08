using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager1 : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}