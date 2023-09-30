using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BedSleep : MonoBehaviour, IInteractable
{
    
    [SerializeField] private PlayerMovement player;
    [SerializeField] private ClockUI clock;

    [SerializeField] private GameObject bedMenu;

    void Awake()
    {
        player.PlayerInteract += onPlayerInteract;
    }

    public void onPlayerInteract()
    {
        

    }


}
