using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Countdown : MonoBehaviour
{
    public int startValue;

    int timeValue;
    public float rate;
    float nextClick;

    [Header("TEXT")]
    public TextMeshPro timerText;


    // Start is called before the first frame update
    void Start()
    {
        timeValue = startValue;
    }

    // Update is called once per frame
    void Update()
    {

        if (timeValue > 10)
        {

            PlayerPrefs.SetInt("Highscore", timeValue);

        }

        if (Time.time > nextClick)
        {

            timeValue -= 1;
            nextClick = Time.time + rate;


            if (timerText != null)
            {
                timerText.text = timeValue.ToString();
            }

        }


    }

    public void AddTime(int _time)
    {

        timeValue += _time;

    }
    public int GetTimeValue()
    {

        return timeValue;

    }

}
