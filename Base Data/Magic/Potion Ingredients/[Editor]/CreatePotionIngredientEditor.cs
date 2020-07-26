using UnityEngine;

[CreateAssetMenu(fileName = "Potion Ingredient", menuName = "Fantasy Data/Magic/Potion Ingredient", order = 6)]
public class CreatePotionIngredientEditor : ScriptableObject
{
    public string potionIngredientId;
    public string potionIngredientName;
    public GameObject potionIngredientModel;
    public float weight;
    public int value;


}