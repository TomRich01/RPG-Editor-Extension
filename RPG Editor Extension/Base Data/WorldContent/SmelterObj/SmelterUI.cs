using Crafting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmelterUI : MonoBehaviour
{
    [SerializeField]
    private RecipeManager recipeManager;
    [SerializeField] private Transform stationContent;
    [SerializeField] private GameObject recipeObj;

    private void Awake()
    {
        recipeManager = FindObjectOfType<RecipeManager>();

    }

    private void OnEnable()
    {
        RedrawUI();
    }

    private void RedrawUI()
    {
        foreach (Transform child in stationContent.transform)
        {
            Destroy(child.gameObject);
        }
        for (int i = 0; i < recipeManager.SmeltingRecipes.Count; i++)
        {
            var item = Instantiate(recipeObj, stationContent.transform);
            var itemComponent = item.GetComponent<SmelterSlotUI>();
            itemComponent.UpdateTitle(recipeManager.SmeltingRecipes[i].recipeName);
            itemComponent.UpdateRecipeObj(recipeManager.SmeltingRecipes[i]);
            itemComponent.UpdateRecipeImage(recipeManager.SmeltingRecipes[i].recipeImage);

        }
    }

}
