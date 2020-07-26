using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Soul Gem", menuName = "Fantasy Data/Items/SoulGem", order = 1)]
public class CreateSoulGemEditor : ScriptableObject
{
    public string prefabId;
    public string prefabName;
    [Space(10)]
    public int soulgemValue;
    public float soulgemWeight;
    [Space(10)]
    public AudioClip useSound;
    public AudioClip pickupSound;
    public AudioClip putdownSound;
    [Space(10)]
    public GameObject prefabModel;
    public bool canHoldNPCSoul;
    [Space(10)]
    [Header("Soul Type")]
    public soulGemType soulType;
    public enum soulGemType
    {
        noneT = 0,
        pettyT = 1,
        creatureT = 2,
        animalMinorT = 3,
        animalMajorT = 4,
        humanT = 5
    }
    [Space(10)]
    [Header("Soul Gem Capacity")]
    public soulGemCapacity soulCapacity;
    public enum soulGemCapacity
    {
        noneC = 0,
        pettyC = 1,
        creatureC = 2,
        animalMinorC = 3,
        animalMajorC = 4,
        humanC = 5
    }
    public bool isFilled;
    




}

  

