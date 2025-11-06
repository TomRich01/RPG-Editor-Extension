using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CapacityMerchant : MonoBehaviour
{
    public Inventory playerInv;
    public CapacityController capacity;
    [SerializeField] Button acceptBtn;

    [SerializeField] private TextMeshProUGUI goldReqText;

    private float costMultiplier = 5f; // Adjust this to control cost rise
    // Save this as a global variable in the save file
   [SerializeField] private int lastBagCapacity = 0;
    [SerializeField] private float goldCost;

    private void Start()
    {
        if (lastBagCapacity == 0)
        {
            goldReqText.text = goldCost.ToString("N0");


        }

    }

    public void BuyCapacityUpgrade()
    {
        Debug.Log("Bought upgrade");
        if (capacity.BagCapacity >= 200)
        {
            goldReqText.text = "Max Bag Space";
            // Capacity reached maximum, do nothing
            return;
        }

        if (lastBagCapacity == 0)
        {
            goldCost = 1500f;
            lastBagCapacity = 1;
        }
        else
        {
            goldCost = 800f * costMultiplier * lastBagCapacity;
        }
        goldReqText.text = goldCost.ToString("N0");
        if (playerInv.playerGold >= goldCost)
        {
            goldReqText.color = Color.white;
            acceptBtn.interactable = true;
            playerInv.playerGold -= (int)goldCost;
            capacity.BagCapacity += 10;
            capacity.UpdateCarryCapacity();
            lastBagCapacity += 1;
            Debug.Log(goldCost);
        }
        else
        {
            goldReqText.color = Color.gray;
            acceptBtn.interactable = false;
        }
        
        
    }



}
