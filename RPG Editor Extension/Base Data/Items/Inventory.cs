using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;

public class Inventory : SerializedMonoBehaviour
{

    [SerializeField] private CapacityController capacityController;

    [OdinSerialize] private List<ItemSO> items; // List of items in inventory

    [SerializeField] public int playerGold;

    public List<ItemSO> Items { get => items; set => items = value; }

    public event Action OnInventoryChanged;

    private void Start()
    {
        playerGold = 457400;
    }
    public int AddItem(ItemSO item, int amount)
    {
        int added = 0;
        for (int i = 0; i < amount; i++)
        {
            if (items.Count >= capacityController.CarryCapacity) break;
            items.Add(item);
            added++;
        }
        OnInventoryChanged?.Invoke();
        return added;
       
    }

    public void RemoveItem(ItemSO item, int amount)
    {  
        while (amount > 0 && items.Contains(item))
        {
            items.Remove(item);
            amount--;
        }
        OnInventoryChanged?.Invoke();
    }

    public void PrintInventory()
    {
        Debug.Log("Inventory contents:");
        foreach (var item in items)
        {
            Debug.Log($"- {item.name}");
        }
    }
}
