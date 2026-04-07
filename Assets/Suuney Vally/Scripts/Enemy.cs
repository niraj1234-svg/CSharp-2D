using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (GameManager.instance.isGameOver) return;

        if (player != null)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.instance.isGameOver) return;

        if (collision.CompareTag("Weapon"))
        {
            GameManager.instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}