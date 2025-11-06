using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Enchantment", menuName = "Fantasy Data/Magic/Enchantment", order = 0)]
public class EnchantmentSO : ScriptableObject
{
    public string enchantmentName;
    public string description;
    public MagicEffect effectType;
    public float magnitude;
    public float duration;
    /* Cast Types:
     * Channeled - must hold down button to cast magic
     * Charged - must press, hold, and release button to fire magic
     * Persistent - effects stay for a duration of time.
     */
    public CastType castType;
    public enum CastType
    {
        CHANNELED,
        CHARGED,
        PERSISTENT

    }
    /* Delivery Types:
     * Self - cast spell on self
     * Hit - cast spell through hit event on weapons
     * Targeted - cast spell via raycast or projectile (if usesProjectile is true)
     * Area - meant for area of effect spells
     */
    public DeliveryType deliveryType;
    public enum DeliveryType
    {
        SELF,
        HIT,
        AREA,
        TARGETED
    }

    public bool usesProjectile;

}
