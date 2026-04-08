using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public DoorController door;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Box"))
        {
            door.OpenDoor();
        }
    }
}
