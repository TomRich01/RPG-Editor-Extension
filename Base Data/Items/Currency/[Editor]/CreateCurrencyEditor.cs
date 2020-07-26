using UnityEngine;

[CreateAssetMenu(fileName = "Currency", menuName = "Fantasy Data/Items/Currency", order = 5)]
public class CreateCurrencyEditor : ScriptableObject
{
    public string currencyId;
    public string currencyName;
    [TextArea]
    public string currencyDescription;
    [Space(10)]
    [Tooltip("Currency value should be set to 1")]
    public int currencyValue;
    public float currencyWeight;
    [Space(10)]
    public AudioClip useSound;
    public AudioClip pickupSound;
    public AudioClip putdownSound;
    [Space(10)]
    public GameObject currencyModel;


}