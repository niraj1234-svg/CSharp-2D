using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI cointext;

    void OnEnable()
    {
        cointext.text = "Coins Collected: " + GameManager.instance.coin;
    }
}