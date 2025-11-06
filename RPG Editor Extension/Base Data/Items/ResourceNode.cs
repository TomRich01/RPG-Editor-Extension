using UnityEngine;

public class ResourceNode : MonoBehaviour
{
    [Tooltip("The resource type for this node, e.g., Wood, Stone, etc.")]
    [SerializeField] private ResourceSO[] resourceNodeTypes;
    [SerializeField] private ResourceSO selectedResourceSO;


    void Start()
    {

        if (resourceNodeTypes.Length > 0)
        {
            SpawnNodeResource();
        }
        else
        {
            Debug.LogWarning("No resource node types assigned to this ResourceNode.");
        }
    }


    private void SpawnNodeResource()
    {
        int randomIndex = Random.Range(0, resourceNodeTypes.Length);
        selectedResourceSO = resourceNodeTypes[randomIndex];

        GameObject spawned = Instantiate(
            selectedResourceSO.resourceNodePrefab,
            transform.position,
            selectedResourceSO.resourceNodePrefab.transform.rotation
        );

        ResourcePickup pickup = spawned.GetComponent<ResourcePickup>();
        if (pickup != null)
        {
            pickup.Initialize(selectedResourceSO);
        }

        Debug.Log($"Spawned resource node of type: {selectedResourceSO.name} at position: {transform.position}");
    }

  
}
