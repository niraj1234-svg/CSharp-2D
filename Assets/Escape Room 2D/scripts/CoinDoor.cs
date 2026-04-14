using UnityEngine;
using TMPro;

public class CoinDoor : MonoBehaviour
{
    public int requiredCoins = 10;
    public TextMeshProUGUI messageText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.instance.coins >= requiredCoins)
            {
                gameObject.SetActive(false);
            }
            else
            {
                messageText.gameObject.SetActive(true);
                messageText.text = "Need " + requiredCoins + " coins!";
                Invoke(nameof(ClearMessage), 2f);
            }
        }
    }

    void ClearMessage()
    {
        messageText.gameObject.SetActive(false);
    }
}