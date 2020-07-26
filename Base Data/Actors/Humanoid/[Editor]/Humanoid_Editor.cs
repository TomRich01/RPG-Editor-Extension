using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Actor", menuName = "Fantasy Data/Actor/Humanoid", order = 0)]
public class Humanoid_Editor : ScriptableObject
{
    public string humanoidName;
    public CreateRaceEditor humanoidRace;
    [Space(10)]
    [TextArea]
    public string BackStory;
    [Space(10)]
    [Header("Actor's job")]
    public JobType Job;
    public enum JobType
    {
        none = 0,
        woodcutter = 1,
        hunter = 2,
        soldier = 3,
        mercenary = 4,
        fisherman = 5,
        merchant = 6,
        official = 7,
        guard = 8,
        bartender = 9,
        maid = 10,
        barmaid = 11,
        bard = 12,
        beggar = 13,
        homeless = 14
    }
    [Space(10)]
    [Header("Actor's Bools")]
    public bool NPC_isAttacked = false;
    public bool NPC_isIdle = true;
    public bool NPC_isSitting = false;
    public bool NPC_isAttacking = false;
    public bool NPC_isSleeping = false;
    public bool NPC_isTalking = false;
    public bool NPC_isShopping = false;

}


