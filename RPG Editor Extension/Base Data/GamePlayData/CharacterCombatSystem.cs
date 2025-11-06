using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class CharacterCombatSystem : MonoBehaviour
{
    private InputReader inputReader;
    [SerializeField] private Animator animator;


    private void Start()
    {
        inputReader = GetComponent<InputReader>();
        inputReader.RightHandLightAttackEvent += TriggerRightHandLightAttack;
        inputReader.RightHandHeavyAttackEvent += TriggerRightHandHeavyAttack;
    }

    private void TriggerRightHandLightAttack()
    {
       LightAttack();
    }
    private void TriggerRightHandHeavyAttack()
    {  
      HeavyAttack();
    }

    private void LightAttack()
    {
        animator.SetTrigger("OneRHLightAttack");
        Debug.Log("Light Attack");
    }

    private void HeavyAttack()
    {
        animator.SetTrigger("OneRHHeavyAttack");
        Debug.Log("Heavy Attack");
    }

   
}
