using UnityEngine;
using TMPro; // You have this, which is good!

public class CoinUI : MonoBehaviour
{
    // Change 'TextMeshPro' to 'TextMeshProUGUI'
    public TextMeshProUGUI cointext;

    void Update()
    {
        // Added .ToString() for cleaner practice, though C# handles the string addition
        cointext.text = "Coin: " + GameManager.instance.coins.ToString();
    }
}