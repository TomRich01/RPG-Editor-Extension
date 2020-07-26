using UnityEngine;

[CreateAssetMenu(fileName = "Resource", menuName = "Fantasy Data/Items/Resource", order = 3)]
public class CreateResourceEditor : ScriptableObject
{
    public string resourceId;
    public string resourceName;
    [TextArea]
    public string ResourceDescription;
    [Space(10)]
    public int resourceValue;
    public float resourceWeight;
    [Space(10)]
    public AudioClip useSound;
    public AudioClip pickupSound;
    public AudioClip putdownSound;
    [Space(10)]
    public GameObject resourceModel;


}