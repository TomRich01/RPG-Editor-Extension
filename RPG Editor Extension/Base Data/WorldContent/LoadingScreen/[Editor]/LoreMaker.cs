using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LoreScreen", menuName = "Fantasy Data/Load Screen/Lore Maker", order = 0)]
public class LoreMaker : ScriptableObject
{
    public GameObject screenModel;
     [TextArea] public string screenText;
}
