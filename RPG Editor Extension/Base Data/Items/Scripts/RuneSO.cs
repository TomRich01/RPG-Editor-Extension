using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Fantasy Data/Items/Rune", order = 7)]
public class RuneSO : ItemSO
{

    public Rarity rarity;
    public enum Rarity
    {
        COMMON,
        FINE,
        SUPERIOR,
        NONE
    }

    public RuneType runeType;
    public enum RuneType
    {
        ELEMENTAL,
        POWER_MODIFIER,
        OPERATION_MODIFIER,
        ABILITY_MODIFIER
    }

    // Elemental runes
    public ElementType? element; // Optional, for elemental runes
    public enum ElementType
    {
        FIRE,
        ICE,
        SHOCK,
        SUSTAIN, // Assuming this represents a healing element
        SUMMON,
        PROTECTION
    }

    // Power modifiers meant for rarity
    public float powerModifierValue;

    // Operation modifiers
    public ModifierOperation operationModifier;
    public enum ModifierOperation
    {
        ADD,
        INCREASE,
        DECREASE,
        MULTIPLY,
        NONE
    }

    // Ability modifiers
    public AffectedAbility affectedAbility;
    public enum AffectedAbility
    {
        WEAPON_DAMAGE,  // Example ability
        HEALING_OUTSIDE_COMBAT,
        STAMINA,
        HEALTH,
        MAGIC
        // Add more as needed
    }

    public float abilityModifierValue;
}
