using UnityEngine;

public class CapacityController : MonoBehaviour
{
    
    [SerializeField] private StaminaController staminaController;
    [SerializeField] private float carryCapacity;
    [SerializeField] private float bagCapacity;
    [SerializeField] private float fortifiedCapacity;

    // Use CarryCapacity for inventory
    public float CarryCapacity { get => carryCapacity; set => carryCapacity = value; }

    // Use BagCapacity for bag merchant upgrades
    public float BagCapacity { get => bagCapacity; set => bagCapacity = value; }

    public void UpdateCarryCapacity()
    {
        carryCapacity = staminaController.Base_Stamina + fortifiedCapacity + bagCapacity;
    }

    private void OnEnable()
    {
        Debug.Log($"Carry capacity: {CarryCapacity}");

    }
}
