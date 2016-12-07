using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cycle : MonoBehaviour
{

    public Light sun;
    public GameObject Moon;
    public float secondsInFullDay = 120f;
    [Range(0, 1)]
    public float currentTimeOfDay = 0;
    //[HideInInspector]
    public float timeMultiplier = 1f;
    public Text text;
    private bool isNight;

    float sunInitialIntensity;

    void Start()
    {
        sunInitialIntensity = sun.intensity;
    }

    void Update()
    {
        UpdateSun();
        UpdateMoon();
        isNightTime();

        currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;

        if (currentTimeOfDay >= 1)
        {
            currentTimeOfDay = 0;
        }
    }

    void isNightTime()
    {
        if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f)
        {
            isNight = true;
        }
        else isNight = false;
        text.text = isNight.ToString();
    }

    void UpdateSun()
    {
        sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 130, 0);

        float intensityMultiplier = 1;
        if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f)
        {
            intensityMultiplier = 0;
        }
        else if (currentTimeOfDay <= 0.25f)
        {
            intensityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.02f));
        }
        else if (currentTimeOfDay >= 0.73f)
        {
            intensityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay - 0.73f) * (1 / 0.02f)));
        }

        sun.intensity = sunInitialIntensity * intensityMultiplier;
    }
    void UpdateMoon()
    {
        if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f)
        {
            Moon.gameObject.SetActive(true);
        }
        else
        {
            Moon.gameObject.SetActive(false);
        }
    }
}