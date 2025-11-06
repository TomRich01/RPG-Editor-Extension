using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Poison", menuName = "Fantasy Data/Items/Magic Items/Poison", order = 2)]

public class PoisonSO : ItemSO
{
    public PoisonType poisonType;
    public enum PoisonType
    {
        Health,
        Stamina,
        Magic
    }

    public Modifier modifier;
    public enum Modifier
    {
        Subtract,
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
    private void ApplyPoisonEffect()
    {
        // Deal damage over time based on damageAmount and effectDuration
    }
}
