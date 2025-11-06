using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill Line", menuName = "ScriptableObjects/Skill Line")]
public class SkillLine : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private UnlockRequirement unlockRequirement;
    [SerializeField] private List<Skill> skills;

    public string Name => name;
    public List<Skill> Skills => skills;

    public enum UnlockRequirement
    {
        Level = 0,
        Quest = 1,
        Other = 2
    }

}
