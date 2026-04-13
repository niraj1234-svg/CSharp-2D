using UnityEngine;

public class PlateSwitch : MonoBehaviour
{
    public MultiDoor door;
    public int plateNumber;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Box") || other.CompareTag("Player"))
        {
            if (plateNumber == 1)
                door.plate1Active = true;
            else
                door.plate2Active = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Box") || other.CompareTag("Player"))
        {
            if (plateNumber == 1)
                door.plate1Active = false;
            else
                door.plate2Active = false;
        }
    }
}