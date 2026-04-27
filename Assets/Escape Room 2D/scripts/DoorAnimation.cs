using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public Transform openPosition;   // where door moves
    public float speed = 2f;

    private bool shouldOpen = false;

    void Update()
    {
        if (shouldOpen)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                openPosition.position,
                speed * Time.deltaTime
            );
        }
    }

    public void OpenDoor()
    {
        shouldOpen = true;
    }
}