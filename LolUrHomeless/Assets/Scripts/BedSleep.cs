using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedSleep : MonoBehaviour, IIinteractable
{
    
    [SerializeField] private PlayerMovement player;
    [SerializeField] private ClockUI clock;



    void Awake()
    {
        player.PlayerInteract += onPlayerInteract;
    }


    public void onPlayerInteract()
    {
        Debug.Log("slept");
    }


}
