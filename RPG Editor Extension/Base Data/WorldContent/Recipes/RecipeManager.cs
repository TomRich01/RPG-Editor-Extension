using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Crafting
{
    public class RecipeManager : MonoBehaviour
    {
        [SerializeField] private List<CraftingRecipeSO> smeltingRecipes = new List<CraftingRecipeSO>();
        public List<CraftingRecipeSO> SmeltingRecipes { get => smeltingRecipes; set => smeltingRecipes = value; }
        

        [SerializeField] private List<CraftingRecipeSO> anvilForgeRecipes = new List<CraftingRecipeSO>();
        public List<CraftingRecipeSO> AnvilForgeRecipes { get => anvilForgeRecipes; set => anvilForgeRecipes = value; }
    }
}

