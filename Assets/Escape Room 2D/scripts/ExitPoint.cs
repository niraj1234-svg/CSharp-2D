using UnityEngine;

public class ExitPoint : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.Wingame();
        }
    }
}
