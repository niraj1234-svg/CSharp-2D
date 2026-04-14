using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI cointext;

    void OnEnable()
    {
        cointext.text = "Coins Collected: " + GameManager.instance.coins;
    }
}