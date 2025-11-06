using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Race", menuName = "Fantasy Data/Race/New Race", order = 0)]

public class RaceEditor : ScriptableObject
{

    public string raceId;
    public string raceName;
    [TextArea(3, 5)]
    public string raceDescription;


    [Header("Major Attributes")]
    public float baseHealth;
    public float baseStamina;
    public float baseMagic;
    public float baseEducation;

    [Header("Minor Attributes")]
    public float basePhysicalStrength;
    public float baseArmorRating;

    [Header("Resistance Attributes")]
    public float baseFireResistance;
    public float baseFrostResistance;
    public float baseShockResistance;
    public float basePhysicalResistance;

}
