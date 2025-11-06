using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterComponent : MonoBehaviour, IHealth, IMagic
{
    [SerializeField] private RaceEditor race;
    [SerializeField] private GenderEditor gender;
    public RaceEditor Race { get => race; set => race = value; }

    [SerializeField] StaminaController staminaController;

    public void Start()
    {
       
                staminaController.Base_Stamina = race.baseStamina;
               
    }

    // Common properties or methods for all character types can be included here

    public virtual void Initialize()
    {
        
        // Common initialization logic
    }


    public virtual void UpdateComponent()
    {
        // Common update logic
    }


    //IHealth, move to self contained
    #region IHealth
    public void Recover(float amount)
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage(float amount)
    {
        throw new System.NotImplementedException();
    }
    #endregion


    //IMagic, move to self contained
    #region IMagic
    public void ConsumeMana(float amount)
    {
        throw new System.NotImplementedException();
    }

    public void RestoreMana(float amount)
    {
        throw new System.NotImplementedException();
    }
    #endregion


    
}
