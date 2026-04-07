using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (GameManager.instance.isGameOver) return;

        movement = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
            movement.y = 1;
        if (Keyboard.current.sKey.isPressed)
            movement.y = -1;
        if (Keyboard.current.aKey.isPressed)
            movement.x = -1;
        if (Keyboard.current.dKey.isPressed)
            movement.x = 1;
    }

    void FixedUpdate()
    {
        if (GameManager.instance.isGameOver) return;

        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager.instance.GameOver(); // ✅ INSTANT GAME OVER
        }
    }
}