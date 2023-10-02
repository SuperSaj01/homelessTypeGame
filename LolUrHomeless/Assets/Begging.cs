using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begging : MonoBehaviour, IIinteractable
{

    [SerializeField] private PlayerMovement player;
    [SerializeField] private ClockUI clock;
    [SerializeField] private GameObject begMenu;

    void Awake()
    {
        player.PlayerInteract += onPlayerInteract;
    }

    public void onPlayerInteract()
    {
        Cursor.lockState = CursorLockMode.Confined;
        begMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Confirm()
    {
        clock.CalculateTimeSkip(hours, 0f);
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
