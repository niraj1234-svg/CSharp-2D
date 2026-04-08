using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Winpanel;
    public void Wingame()
    {
        Time.timeScale = 0f;
        Winpanel.SetActive(true);
    }
}
