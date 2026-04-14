using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothspeed = 5f;
    public Vector3 offset;
    private void LateUpdate()
    {
        Vector3 targetposition = player.position + offset;
        transform.position = Vector3.Lerp(
            transform.position,
            targetposition, 
            smoothspeed * Time.deltaTime);
    }
}
