using UnityEngine;
public class Wapone : MonoBehaviour
{
    public int rotationspeed = 200;
    public Vector3 rotationpoint = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotationAmount = rotationspeed * Time.deltaTime;
        transform.RotateAround(rotationpoint, Vector3.forward, rotationAmount);
    }
}
