using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Begging : MonoBehaviour, IIinteractable
{
    public GameObject player;
    [SerializeField] private ClockUI clock;
    [SerializeField] private GameObject begMenu;
    private float normalTimeRun;
    [SerializeField] private Text hoursAddedOnText;
    private float hours;

  void Awake()
    {
        begMenu.SetActive(false);
        normalTimeRun = Time.timeScale;
    }

    public void onPlayerInteract()
    {
        Cursor.lockState = CursorLockMode.Confined;
        begMenu.SetActive(true);
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

    void CalculateMoneyEarned(float hours)
    {
        player.GetComponent<PlayerStats>().money += hours;
        Debug.Log("grg");
    }

    public void Confirm()
    {
        CalculateMoneyEarned(hours);
    }

    public void OnExit()
    {
        begMenu.SetActive(false);
        Confirm();
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = normalTimeRun;

    }
}
