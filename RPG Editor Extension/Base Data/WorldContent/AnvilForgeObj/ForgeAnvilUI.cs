using Crafting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForgeAnvilUI : MonoBehaviour
{
    [SerializeField]
    private RecipeManager recipeManager;
    [SerializeField] private Transform stationContent;
    [SerializeField] private GameObject recipeSlotObj;

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
        for (int i = 0; i < recipeManager.AnvilForgeRecipes.Count; i++)
        {
            var item = Instantiate(recipeSlotObj, stationContent.transform);
            var itemComponent = item.GetComponent<ForgeAnvilSlotUI>();
            itemComponent.UpdateTitle(recipeManager.AnvilForgeRecipes[i].recipeName);
            itemComponent.UpdateRecipeObj(recipeManager.AnvilForgeRecipes[i]);
            itemComponent.UpdateRecipeImage(recipeManager.AnvilForgeRecipes[i].recipeImage);

        }
    }
}
