using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    
    public float hunger, warmth, energy;
    float maxStat = 100f;

    public float money;

    public float drain {get; set;}
    public float energyDrain = 20f;

    public Text moneyblaty;

    public Slider energySlider;
    public Slider warmthSlider;
    public Slider hungerSlider;

    private PlayerMovement playerMovment;

    void Start()
    {
        playerMovment = GetComponent<PlayerMovement>();

        hunger = maxStat;
        warmth = maxStat;
        energy = maxStat;
        drain = 10f;

    }

    // Update is called once per frame
    void Update()
    {
        energy -= Time.deltaTime * energyDrain;
        hunger -= Time.deltaTime * energyDrain;
        
        

        if(energy <= 0)
        {
            Debug.Log("energy ran out");
        }

        energySlider.value = energy;
        warmthSlider.value = warmth;
        hungerSlider.value = hunger;
        
        moneyblaty.text = money.ToString();

    }


    

    
}
