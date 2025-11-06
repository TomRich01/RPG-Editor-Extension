using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private ItemSO inventoryItem = null;
    [SerializeField] private Image itemImage = null;


    public void UpdateTitle(string title)
    {
        titleText.text = title;
    }

    public void UpdateItemObj(ItemSO item)
    {
        inventoryItem = item;
    }

    public void UpdateItemImage(Sprite image)
    {
        itemImage.sprite = image;
    }
}
