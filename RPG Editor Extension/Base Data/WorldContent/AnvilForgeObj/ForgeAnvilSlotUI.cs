using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ForgeAnvilSlotUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private CraftingRecipeSO recipeSO = null;
    [SerializeField] private Image recipeImage = null;


    public void UpdateTitle(string title)
    {
        titleText.text = title;
    }

    public void UpdateRecipeObj(CraftingRecipeSO craftingRecipe)
    {
        recipeSO = craftingRecipe;
    }

    public void UpdateRecipeImage(Sprite image)
    {
        recipeImage.sprite = image;
    }

    public void ProduceRecipeItem()
    {

        Inventory playerInventory = GetComponentInParent<Inventory>();
        if (recipeSO != null)
        {
            MatRequirements[] requiredMaterials = recipeSO.requirements;
            bool hasAllRequirements = true;

            foreach (MatRequirements requirement in requiredMaterials)
            {
                bool hasEnough = playerInventory.Items.Contains(requirement.item);
                if (hasEnough)
                {
                    int itemCount = playerInventory.Items.Count(i => i.Equals(requirement.item));
                    hasEnough = itemCount >= requirement.itemAmount;
                }

                if (!hasEnough)
                {
                    // Inform the player about missing resources
                    hasAllRequirements = false;
                    break;
                }
            }

            if (hasAllRequirements)
            {
                playerInventory.AddItem(recipeSO.itemRecipeProduces, recipeSO.productionAmount);
                foreach (MatRequirements requirement in requiredMaterials)
                {
                    playerInventory.RemoveItem(requirement.item, requirement.itemAmount);
                }

                
            }
        }
    }
}
