using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMultiSpellObject", menuName = "Multi Magic System/Multi Spell Object")]
public class MultiSpellObjectSO : ScriptableObject
{
 public List<SpellCombination> combinations;
    
}

[System.Serializable]
public class SpellCombination
{
    public SpellObjectSO spell1;
    public SpellObjectSO spell2;
    public SpellObjectSO combinedSpell;

    public SpellCombination(SpellObjectSO s1, SpellObjectSO s2, SpellObjectSO combined)
    {
        spell1 = s1;
        spell2 = s2;
        combinedSpell = combined;
    }
}