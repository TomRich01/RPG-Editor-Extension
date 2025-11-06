using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName = "ScriptableObjects/Skill")]
public class Skill : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private string description;
    [SerializeField] private SkillType skillType;
    [SerializeField] private Effect effect;
    [SerializeField] private Cost cost;
    [SerializeField] private int levelRequirement;

    public string Name => name;
    public string Description => description;
    public int LevelRequirement => levelRequirement;

    public enum SkillType
    {
        Passive,
        Active
    }

    // Define Effect and Cost classes based on your game's needs
    [System.Serializable]
    public class Effect
    {
        [SerializeField] private EffectType effectType;
        [SerializeField] private float value; // Adjust as needed for different effect types
        [SerializeField] private float duration; // Optional for effects with durations
                                                 // Add other fields as needed (e.g., area of effect, targeting, conditions)

        
        public float Value => value;
        public float Duration => duration;

        public enum EffectType
        {
            Damage,
            Healing,
            Buff,
            Debuff,
            // Add other effect types as needed
        }
    }

    [System.Serializable]
    public class Cost
    {
        [SerializeField] private CostType costType;
        [SerializeField] private float value; // Adjust as needed for different cost types
        [SerializeField] private float cooldown; // Optional for cooldown-based costs
                                                 // Add other fields as needed (e.g., resource pools, conditions)

        public float Value => value;
        public float Cooldown => cooldown;

        public enum CostType
        {
            Magic,
            Stamina,
            Health,
            Cooldown,
            // Add other cost types as needed
        }
    }
}
