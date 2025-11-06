using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Fantasy Data/Items/Runestone", order = 8)]
public class RunestoneSO : ItemSO
{
    public ItemType compatibleItemType;
    public enum ItemType
    {
        ARMOR,
        JEWELRY,
        WEAPON
    }

    public List<RuneSO> requiredRunes;
    public EnchantmentSO unlockedEnchantment;
}
