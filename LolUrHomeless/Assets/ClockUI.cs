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


    private const float Real_Secounds_Per_InGame_Day = 600f;

    private float day;

    private void Awake()
    {
        timeText = time.GetComponent<Text>();
        dayText = dayObj.GetComponent<Text>();
    }

    private void Update()
    {
        

        day += Time.deltaTime / Real_Secounds_Per_InGame_Day;

        float dayNormalised = day % 1f;

        hourHand.eulerAngles = new Vector3(0, 0, -dayNormalised * 360f * 2f);

        
        minuteHand.eulerAngles = new Vector3(0, 0, -dayNormalised * 360f * hoursPerDay);

        
        string hoursString = Mathf.Floor(dayNormalised * hoursPerDay).ToString("00");
        string minutesString = Mathf.Floor(((dayNormalised * hoursPerDay) % 1f) * minutesPerHour).ToString("00");

        timeText.text = hoursString + ":" + minutesString;
        dayText.text = "Day " + Mathf.Floor(day);
    }
}
