using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Fantasy Data/Items/Weapon", order = 1)]
public class WeaponSO : ItemSO
{

    public int weaponDMG;

    [Header("Weapon Type")]
    public WeaponType weaponType;
    public enum WeaponType
    {
        melee = 0,
        ranged = 1,
        unarmed = 2
        
    }
    
}
