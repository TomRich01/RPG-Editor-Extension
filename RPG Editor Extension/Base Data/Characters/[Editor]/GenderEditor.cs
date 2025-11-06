using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Gender", menuName = "Fantasy Data/Gender/Create Gender", order = 0)]
public class GenderEditor : ScriptableObject
{
    public GenderType genderType;

    public enum GenderType
    {
        Male = 0,
        Female = 1
    }
}
