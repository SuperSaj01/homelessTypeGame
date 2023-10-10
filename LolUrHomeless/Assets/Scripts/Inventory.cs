using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
   private List<Item> itemList;

   public Inventory()
   {
    itemList = new List<Item>();

    AddItem(new Item { itemType = Item.ItemType.Food, amount = 1});
    AddItem(new Item { itemType = Item.ItemType.Bandages, amount = 3});
    AddItem(new Item { itemType = Item.ItemType.Clothes, amount = 1});
    AddItem(new Item { itemType = Item.ItemType.Random, amount = 5});
    AddItem(new Item { itemType = Item.ItemType.Useless, amount = 34});
    AddItem(new Item { itemType = Item.ItemType.Tools, amount = 2});

    Debug.Log(itemList.Count);
   }

   public void AddItem(Item item)
   {
        itemList.Add(item);
   }

   public List<Item> GetItemList()
   {
        return itemList;
   }
}
