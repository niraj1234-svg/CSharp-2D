using UnityEngine;

public class MultiDoor : MonoBehaviour
{
    public bool plate1Active = false;
    public bool plate2Active = false;
    private void Update()
    {
        if(plate1Active && plate2Active)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
