using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;
    public AudioSource Coinsound;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            {
            GameManager.instance.AddCoin(value);
            Coinsound.Play();
            Destroy(gameObject,0.1f);
        }
    }
}
