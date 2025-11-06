using UnityEngine;

public class ResourcePickup : MonoBehaviour, IInteractable
{
    [SerializeField] private ResourceSO resourceSO;
    [SerializeField] private int amount = 1;

    private Inventory inventory;

    private void Awake()
    {
        inventory = FindObjectOfType<Inventory>();
        if (inventory == null)
        {
            Debug.LogError("No Inventory found in the scene!");
        }
    }
    public void Initialize(ResourceSO resource)
    {
        resourceSO = resource;
    }
    public string GetInteractionText()
    {
        return $"Collect {resourceSO.name} x{amount}";
    }

    public void Interact()
    {
        // Handle pickup logic
        Debug.Log($"Picked up {amount}x {resourceSO.name}");

        // Add to inventory, spawn VFX, etc.
        inventory.AddItem(resourceSO, amount);
        Debug.Log($"Added {amount}x {resourceSO.name} to inventory");
        inventory.PrintInventory();
 

        Destroy(gameObject); // or trigger a harvest animation, etc.
    }
}