using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public static GameManager instance;

    public bool isGameOver = false;

    void Awake()
    {
        instance = this;
        score = 0;
        Time.timeScale = 1f;
    }

    public void AddScore(int amount)
    {
        if (isGameOver) return;

        score += amount;
        Debug.Log("Score: " + score);
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;

        Debug.Log("GAME OVER");

        // Stop entire game
        Time.timeScale = 0f;
    }
}