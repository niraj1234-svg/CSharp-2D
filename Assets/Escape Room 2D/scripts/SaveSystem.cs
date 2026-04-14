using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static void SaveGame(int coins, int level)
    {
        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.SetInt("Level", level);
        PlayerPrefs.Save();
    }

    public static int LoadCoins()
    {
        return PlayerPrefs.GetInt("Coins", 0);
    }

    public static int LoadLevel()
    {
        return PlayerPrefs.GetInt("Level", 0);
    }
}