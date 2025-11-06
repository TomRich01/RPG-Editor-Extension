using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class StaminaController : MonoBehaviour, IStamina
{
    [SerializeField] private float base_stamina;
    [SerializeField] private float currentStamina;

    public float Stamina { get => currentStamina; set => currentStamina = value; }
    public float Base_Stamina { get => base_stamina; set => base_stamina = value; }

    private void Start()
    {
        
        currentStamina = Base_Stamina;
    }
    public void Deplete(float amount)
    {
        Debug.Log("Depleting stamina by: " + amount);
        currentStamina = currentStamina - amount;
        Debug.Log("Current Stamina: " + currentStamina);
    }

    public void Replenish(float amount)
    {
        Debug.Log("Replenish stamina by: " + amount);
        currentStamina = currentStamina + amount;
        Debug.Log("Current Stamina: " + currentStamina);
    }
}
