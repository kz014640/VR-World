using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text timeText;
    private float startTime;
    public bool nxtlev = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (nxtlev)
            return;

            float t = Time.time - startTime;

            string minuets = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timeText.text = minuets + "." + seconds;
    }
    public void Next()
    {
        nxtlev = true;
        timeText.color = Color.yellow;
    }
}
