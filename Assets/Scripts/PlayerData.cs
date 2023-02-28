using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    //general
    public double time;

    //stats
    public float score;
    public float hitPower;
    public float cps;
    public float offlineMultiplier;

    //shop
    public bool[] itemPurchased;
    public long[] amountPurchased;
    public float[] itemCost;

    public PlayerData (GameController gameController)
    {
        time = gameController.saveTime;
        offlineMultiplier = gameController.offlineMultiplier;
        score = gameController.currentScore;
        hitPower = gameController.hitPower;
        cps = gameController.cps;

        itemPurchased = new bool[gameController.shopInventory.shopItems.Count];
        amountPurchased = new long[gameController.shopInventory.shopItems.Count];
        itemCost = new float[gameController.shopInventory.shopItems.Count];

        for(int i = 0; i < gameController.shopInventory.shopItems.Count; i++)
        {
            itemPurchased[i] = gameController.shopInventory.shopItems[i].itemPurchased;
            amountPurchased[i] = gameController.shopInventory.shopItems[i].amountPurchased;
            itemCost[i] = gameController.shopInventory.shopItems[i].itemCost;
        }     
    }

}
