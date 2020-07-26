using UnityEngine;

[CreateAssetMenu(fileName = "Food", menuName = "Fantasy Data/Items/Food", order = 6)]
public class CreateFoodEditor : ScriptableObject
{

    // Works for both food and drink.
    public string foodId;
    public string foodName;
    [Space(10)]
    public int foodValue;
    public float foodWeight;
    [Space(10)]
    public AudioClip useSound;
    public AudioClip pickupSound;
    public AudioClip putdownSound;
    [Space(10)]
    public GameObject foodModel;
    public int foodHealthRestore;
    public int foodStaminaRestore;
    public int foodMagicRestore;


}
