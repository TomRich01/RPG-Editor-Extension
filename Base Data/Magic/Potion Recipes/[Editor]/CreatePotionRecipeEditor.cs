using UnityEngine;

[CreateAssetMenu(fileName = "Potion Recipe", menuName = "Fantasy Data/Magic/Potion Recipe", order = 5)]
public class CreatePotionRecipeEditor : ScriptableObject
{
    public string potionRecipeId;
    public string potionRecipeName;
    public CreatePotionIngredientEditor[] potionIngredientsNeeded;


}
