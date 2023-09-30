using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedSleep : MonoBehaviour
{
    
    [SerializeField] private PlayerMovement player;
    [SerializeField] private ClockUI clock;



    void Awake()
    {
        player.PlayerInteract += onPlayerInteract;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onPlayerInteract()
    {
        Debug.Log("slept");
    }


}
