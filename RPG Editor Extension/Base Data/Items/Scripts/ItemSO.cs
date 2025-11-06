using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Fantasy Data/Items/Item", order = 0)]
public class ItemSO : ScriptableObject, IInventoryItem
{
    public string itemID = Guid.NewGuid().ToString();
    public string itemName;
    public string itemDescription;
    [Space(10)]
    public int itemValue;
    public float itemWeight;
    [Space(10)]
    public AudioClip useSound;
    public AudioClip pickupSound;
    public AudioClip putdownSound;
    [Space(10)]
    public GameObject itemObj;
    public Sprite itemIcon;

    public bool IsStackable { get; } // Existing property
    public int maxStackSize;
    public virtual int GetMaxStack() // Optional if maxStack defined directly
    {
        return maxStackSize;
    }

    public virtual bool IsItemStackable() // Optional if isStackable defined directly
    {
        return IsStackable;
    }
}
