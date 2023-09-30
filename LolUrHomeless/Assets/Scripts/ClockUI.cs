using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUI : MonoBehaviour
{

    [SerializeField] private Transform hourHand;
    [SerializeField] private Transform minuteHand;
    [SerializeField] private GameObject time;
    [SerializeField] private GameObject dayObj;

    private Text timeText;
    private Text dayText;

    private float hoursPerDay = 24f;
    private float minutesPerHour = 60f;

    float minutes;
    float hours;

    bool resumeTime;

    private const float Real_Secounds_Per_InGame_Day = 600f;

    private float day;

    private void Awake()
    {
        timeText = time.GetComponent<Text>();
        dayText = dayObj.GetComponent<Text>();

        OutputTime(1f, 0f);
    }

    private void Update()
    {
        if(!resumeTime)
        {
            OnTimeNormal();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            day += (6f / (24 * 60));
        }
    }

    void OnTimeNormal()
    {
        day += Time.deltaTime / Real_Secounds_Per_InGame_Day;

        float dayNormalised = day % 1f;



        hourHand.eulerAngles = new Vector3(0, 0, -dayNormalised * 360f * 2f);

        minuteHand.eulerAngles = new Vector3(0, 0, -dayNormalised * 360f * hoursPerDay);

        
        hours = dayNormalised * hoursPerDay;
        minutes = (dayNormalised * hoursPerDay) % 1f;

        OutputTime(hours, minutes);
        
    }

    void OutputTime(float hours, float minutes)
    {
        string hoursString = Mathf.Floor(hours).ToString("00");
        string minutesString = Mathf.Floor((minutes) * minutesPerHour).ToString("00");

        timeText.text = hoursString + ":" + minutesString;
        dayText.text = "Day " + Mathf.Floor(day);
    }

    int CalculateTimeSkip(float hours, float minutes)
    {
        return 0;

    }
    
}
