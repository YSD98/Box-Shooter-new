using UnityEngine;
using TMPro;

public class Canvass : MonoBehaviour
{
    public TMP_Text Score;
    void Update()
    {
        int timee = 20 - (int)Time.time;
        
        if (timee<=0)
            Score.text = "Game Over";
        else
            Score.text = timee.ToString();
    }
}
