using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;
    public AudioSource Coinsound;
    public GameObject collectEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddCoin(value);

            Instantiate(collectEffect, transform.position, Quaternion.identity);

            Coinsound.Play();

            Destroy(gameObject, 0.1f);
        }
    }
}
