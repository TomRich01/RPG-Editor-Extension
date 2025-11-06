using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpellBook", menuName = "Fantasy Data/Items/SpellBook", order = 9)]
public class SpellbookSO : ItemSO
{
   public List<SpellObjectSO> spells = new List<SpellObjectSO>();

    public void AddSpell(SpellObjectSO spell)
    {
        if (spells.Count < 10)
        {
            spells.Add(spell);
        }
        else
        {
            Debug.Log("max spells added");
            return;
        }
    }
}



