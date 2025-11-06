using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Crafting Recipe", menuName = "Fantasy Data/CraftingRecipe", order = 0)]

public class CraftingRecipeSO : ScriptableObject
{
    public string recipeID = Guid.NewGuid().ToString();
    public string recipeName;
    public string recipeDescription;
    public Sprite recipeImage;
    public ItemSO itemRecipeProduces;
    public MatRequirements[] requirements;
    public int productionAmount = 1;
}

[System.Serializable]
public class MatRequirements
{
    [Header("Resources Required")]
    public ItemSO item;
    public int itemAmount;
}
