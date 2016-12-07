using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public float daySpeedModifyer;
    public float nightSpeedModifyer;

    public int speedMultiplyer;

    public Text MiliSecondText;
    public Text HourText;
    public Text MinuteText;
    public Text SecondText;
    public Text DayText;
    public Text testText;
    private int milisecond;
    public int second;
    public int hour;
    public int minute;
    public int day;
    
    

    private Vector3 time;

    void Start ()
    {
        milisecond = 0;
    }

    void FixedUpdate()
    {
        Tick();
        HourText.text = hour.ToString("00");
        MinuteText.text = minute.ToString("00");
        SecondText.text = second.ToString("00");
        MiliSecondText.text = milisecond.ToString("00");
        DayText.text = day.ToString("00");
        //testText.text = Time.deltaTime.ToString("00");
        //testText.text = currentSecond.ToString();
        //testText.text = time.ToString();
    }

    private void Tick()
    {
        if (speedMultiplyer != 0)
        {
            milisecond *= speedMultiplyer;
            second *= speedMultiplyer;
        }
            milisecond++;
            if (milisecond >= 60)
            {
                milisecond = 0;
                second++;
            }
            if (second >= 60)
            {
                second = 0;
                minute++;
            }
            if (minute >= 60)
            {
                minute = 0;
                hour++;
            }
            if (hour > 23)
            {
                hour = 0;
                day++;
            }
    }

}
