using UnityEngine;

[CreateAssetMenu(fileName = "Potion", menuName = "Fantasy Data/Magic/Potion", order = 1)]
public class CreatePotionEditor : ScriptableObject
{
    [Tooltip("Keep the text together: Gold001.")]
    public string prefabId;
    public string prefabName;
    public Object script;
    [Space(10)]
    public GameObject prefabModel;
    public GameObject prefabEffect;
    [Space(10)]
    public bool FoodItem;
    public bool MedicineItem;
    public bool PoisonItem;
    [Space(10)]
    public AudioClip useSound;
    public AudioClip pickupSound;
    public AudioClip putdownSound;
    [Space(10)]
    public int potionValue;
    public float potionWeight;

    public CreatePotionRecipeEditor potionRecipe;
   

}