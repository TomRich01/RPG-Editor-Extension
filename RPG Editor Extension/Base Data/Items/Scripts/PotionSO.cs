using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Potion", menuName = "Fantasy Data/Items/Magic Items/Potion", order = 1)]
public class PotionSO : ItemSO
{
    public PotionType potionType;
    public enum PotionType
    {
        Health,
        Stamina,
        Magic
    }

    public Modifier modifier;
    public enum Modifier
    {
        Add,
        Multiply
    }

    [Header("Effect amounts")]
    public float restoreAmount;
    public float effectLingerAmount;
    public float effectLingerDuration;
    [Tooltip("Cooldown period before using next potion of this type")]
    public float cooldownTimeRequired;

    // Method to apply potion effects
    public void ApplyEffect()
    {
       
    }

    // Helper methods for specific effects (optional)
    private void ApplyRestoreEffect()
    {
        // Restore health based on healingAmount
    }

}