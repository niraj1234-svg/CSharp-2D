using UnityEngine;

public class AxeRotation : MonoBehaviour
{
    public float rotationSpeed = 200f;

    void Update()
    {
        if (GameManager.instance.isGameOver) return;

        transform.RotateAround(transform.parent.position, Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}