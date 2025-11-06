using UnityEngine;

[CreateAssetMenu(fileName = "Spell", menuName = "Fantasy Data/Magic/Spell", order = 2)]
public class SpellObjectSO : ScriptableObject
{
    public string spellId;
    public string spellName;
    [TextArea]
    public string spellDescription;
    [Space(10)]
    [Header("Type of spell")]
    public MagicEffect magicEffect;
    [Space(10)]
    [Header("Place to equip spell")]
    public EquipSpellBy equipSpell;
    public enum EquipSpellBy
    {
        equipBothHands = 0,
        equipRightHand = 1,
        equipLeftHand = 2,
        equipEitherHand = 3,
        equipNone = 4
    }


    [Space(10)]
    [Header("spell cost")]
    public bool spellRandom = false;
    public int spellMagicCost;
    public float spellCastTime;
    [Space(10)]
    [Header("type of spell")]
    public SpellField Field;
    public enum SpellField
    {
        conjuration = 0,
        destruction = 1,
        restoration = 2,
        necromancy = 3,
        transmutation = 4
    }

    [Space(10)]
    [Header("type of spell control")]
    public SpellControl Control;
    public enum SpellControl
    {
        FullFire = 0,
        WaitToFire = 1,
        CastOnOther = 2,
        CastOnSelf = 3
    }






    private void OnValidate()
    {
        if (spellRandom)
        {
            spellMagicCost = Random.Range(10, 200);
            spellCastTime = Random.Range(0.5f, 3);
        }
    }
}
