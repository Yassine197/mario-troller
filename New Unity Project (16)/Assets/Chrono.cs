using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    private string timedis;
    private float sec;
    private int min;
    private int hou;
    private TextMesh text;

    public bool startime = false;
    void Start()
    {
        text = gameObject.GetComponent<TextMesh>();
        sec = 0;
        min = 0;
        hou = 0;
    }
    void Update()
    {
        //Count time only whent this is true
        if (startime == true)
        {
            //Adding seconds
            sec += Time.deltaTime;
            //Adding minutes
            if (Mathf.Floor(sec) >= 60) { sec = 0; min = min + 1; }
            //Adding hours
            if (min >= 60) { min = 0; hou = hou + 1; }
            //Display time
            timedis = (hou.ToString() + ":" + min.ToString() + ":" + Mathf.Floor(sec).ToString());
            text.text = timedis;
        }
    }
}
