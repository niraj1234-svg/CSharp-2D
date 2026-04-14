using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI Timertext;
    float time;
    private void Update()
    {
        time += Time.deltaTime;
        Timertext.text = "Time:" + time.ToString("F1");
    }
}
