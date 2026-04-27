using UnityEngine;

public class PressurePlate1 : MonoBehaviour
{
    public DoorAnimation door; // reference to door script

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            door.OpenDoor();
        }
    }
}