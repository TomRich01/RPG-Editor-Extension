using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Relation", menuName = "Fantasy Data/Character/Association", order = 0)]
public class CreateAssociationEditor : ScriptableObject
{
    public string associationId;
    public string associationName;

    [Header("Married Status")]
    [SerializeField] private bool Married;
    [Space(10)]
    [Header("Male Roles")]
    public HumanoidActor FatherOf;
    public HumanoidActor SonOf;
    public HumanoidActor MSpouseOf;
    public HumanoidActor UncleOf;
    [Space(10)]
    [Header("Female Roles")]
    public HumanoidActor MotherOf;
    public HumanoidActor DaughterOf;
    public HumanoidActor FSpouseOf;
    public HumanoidActor AuntOf;

}










/*    [Header("Married")]
    public equipSpellBy equipSpell;
    public enum equipSpellBy
    {
        equipBothHands = 0,
        equipRightHand = 1,
        equipLeftHand = 2,
        equipEitherHand = 3,
        equipNone = 4
    }
*/