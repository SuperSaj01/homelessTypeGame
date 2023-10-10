using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public enum ItemType
    {
        Food,
        Bandages,
        Clothes,
        Water,
        Tools,
        Random,
        Useless,
    }

    public ItemType itemType;
    public int amount;

}
