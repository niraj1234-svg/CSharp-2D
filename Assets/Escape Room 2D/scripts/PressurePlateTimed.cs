using UnityEngine;

public class PressurePlateTimed : MonoBehaviour
{
    public TimedDoor door;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            door.OpenDoor();
        }
    }
}