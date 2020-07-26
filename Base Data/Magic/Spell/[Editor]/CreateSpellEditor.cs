using UnityEngine;

[CreateAssetMenu(fileName = "Spell", menuName = "Fantasy Data/Magic/Spell", order = 2)]
public class CreateSpellEditor : ScriptableObject
{
    public string spellId;
    public string spellName;
    [TextArea]
    public string spellDescription;
    [Space(10)]
    [Header("Type of spell")]
    public CreateMagicEffectEditor magicEffect;
    [Space(10)]
    [Header("Place to equip spell")]
    public equipSpellBy equipSpell;
    public enum equipSpellBy
    {
        equipBothHands = 0,
        equipRightHand = 1,
        equipLeftHand = 2,
        equipEitherHand = 3,
        equipNone = 4
}
    

    [Space(10)]
    [Header("spell cost")]
    public bool spellRandom =  false;
    public int spellMagicCost;
    public float spellCastTime;
    [Space(10)]
    [Header("type of spell")]
  public spellField Field;
    public enum spellField
    {
        conjuration = 0,
        destruction = 1,
        restoration = 2,
        necromancy = 3,
        transmutation = 4
    }

    [Space(10)]
    [Header("type of spell control")]
    public spellControl Control;
    public enum spellControl
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

   






    /*    public bool equipFeet;
    public bool equipShield;
    public bool equipBack;
    public bool equipHead;
    public bool equipSideRight;
    public bool equipSideLeft;
    public bool equipBody;
    public bool equipBodyArmor;
    public bool equipRightFinger;
    public bool equipLeftFinger;
    public bool equipNeck; */
}
 