using UnityEngine;
using System.Collections;

public class TimedDoor : MonoBehaviour
{
    public float openTime = 3f;

    private bool isOpen = false;

    private Collider2D col;
    private SpriteRenderer sr;

    void Start()
    {
        col = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    public void OpenDoor()
    {
        if (!isOpen)
        {
            StartCoroutine(OpenDoorRoutine());
        }
    }

    IEnumerator OpenDoorRoutine()
    {
        isOpen = true;

        // OPEN DOOR
        col.enabled = false;   // player can pass
        sr.enabled = false;    // invisible

        yield return new WaitForSeconds(openTime);

        // CLOSE DOOR
        col.enabled = true;
        sr.enabled = true;

        isOpen = false;
    }
}