using Crafting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private Inventory playerInventory;
    [SerializeField] private Transform inventoryContent;
    [SerializeField] private GameObject inventorySlotObj;

    void OnEnable()  // subscribe once
    {
        playerInventory.OnInventoryChanged += RedrawUI;
    }

    void OnDisable() // remember to unsubscribe
    {
        playerInventory.OnInventoryChanged -= RedrawUI;
    }
    private void Awake()
    {
        playerInventory = FindObjectOfType<Inventory>();
        if (playerInventory == null)
        {
            Debug.LogError("No Inventory found in the scene. Please ensure an Inventory component is present.");
        }
    }

    private void RedrawUI()
    {

        // Get each child transform in the station's UI panel
        foreach (Transform child in inventoryContent.transform)
        {
            Destroy(child.gameObject);
        }
        for (int i = 0; i < playerInventory.Items.Count; i++)
        {
            var item = Instantiate(inventorySlotObj, inventoryContent.transform);
            var itemComponent = item.GetComponent<InventorySlotUI>();
            itemComponent.UpdateTitle(playerInventory.Items[i].itemName);
            itemComponent.UpdateItemObj(playerInventory.Items[i]);
            itemComponent.UpdateItemImage(playerInventory.Items[i].itemIcon);

        }
    }
}
