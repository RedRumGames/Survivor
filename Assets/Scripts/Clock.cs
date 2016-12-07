using UnityEngine;

public class Clock : MonoBehaviour
{

    public Transform hourHand;
    public Transform minuteHand;

    float hoursToDegrees = 360f / 12f;
    float minutesToDegrees = 360f / 60f;
    Cycle controller;

    void Awake()
    {
        controller = GameObject.Find("cycle").GetComponent<Cycle>();
    }

    void Update()
    {
        float currentHour = 24 * controller.currentTimeOfDay;
        float currentMinute = 60 * (currentHour - Mathf.Floor(currentHour));

        hourHand.localRotation = Quaternion.Euler(0, 0, -(currentHour * hoursToDegrees));
        minuteHand.localRotation = Quaternion.Euler(0, 0, -(currentMinute * minutesToDegrees));
    }
}