using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "House", menuName = "Fantasy Data/Houses/House", order = 0)]
public class HouseSO : ScriptableObject
{
    public string displayName;
    public string ref_name;
    public int goldCost;
}
