using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Class", menuName = "Fantasy Data/Character/Class", order = 1)]
public class CreateClassEditor : ScriptableObject
{
    public string classId;
    public string className;
    [Space(10)]
    [Header("Stats")]
    public int healthClass; [Tooltip("the type of health for group")]
    public int staminaClass;
    public int magicClass;


}