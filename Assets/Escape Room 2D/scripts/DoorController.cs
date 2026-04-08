using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    public void OpenDoor()
    {
        door.SetActive(false);
    }
}
