using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campfire : MonoBehaviour
{
    
    private float warmthGivenOut = -10;
    [SerializeField] private Transform playerPos;
    private float maxDistanceFromPlayer = 10f;

    void Update()
    {
        float distance = (playerPos.position - transform.position).magnitude;
        if(distance <= maxDistanceFromPlayer)
        {
            playerPos.GetComponent<PlayerStats>().energyDrain = warmthGivenOut;
        }
        else 
        {
            playerPos.GetComponent<PlayerStats>().energyDrain = playerPos.GetComponent<PlayerStats>().drain;
        }

    }

}
