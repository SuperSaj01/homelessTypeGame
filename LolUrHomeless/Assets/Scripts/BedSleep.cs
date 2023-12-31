using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BedSleep : MonoBehaviour, IIinteractable
{
    
    private bool isMenuActive;

    [SerializeField] private ClockUI clock;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject sleepMenu;
    [SerializeField] private GameObject addHours;
    [SerializeField] private GameObject subtractHours;

    private float hours; 
    [SerializeField] private Text hoursAddedOnText;

    private float normalTimeRun; 


    void Awake()
    {
        sleepMenu.SetActive(false);
        normalTimeRun = Time.timeScale;
    }

    public void onPlayerInteract()
    {
        isMenuActive = true;
        Cursor.lockState = CursorLockMode.Confined;
        sleepMenu.SetActive(true);
        Time.timeScale = 0;
    }


    public void CalculateHoursOfSleep(int hours)
    {
        this.hours += hours;
        
        if(this.hours < 0)
        {
            this.hours = 0;
        }

        string hoursAdded = Mathf.Clamp(this.hours, 0, 99).ToString("00");
    
        hoursAddedOnText.text = hoursAdded;
    
        
       
    }

    public void Confirm()
    {
        clock.CalculateTimeSkip(hours, 0f);
        CalculateSleepReplenish();
        
    }

    private void CalculateSleepReplenish()
    {
        player.GetComponent<PlayerStats>().energy += hours * 10f;
    }

    public void OnExit()
    {
        Confirm();
        isMenuActive = false;
        Cursor.lockState = CursorLockMode.Locked;
        sleepMenu.SetActive(false);
        Time.timeScale = normalTimeRun;

        hours = 0;
    }

}
