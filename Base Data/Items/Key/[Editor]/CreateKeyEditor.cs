using UnityEngine;

[CreateAssetMenu(fileName = "Key", menuName = "Fantasy Data/Items/Key", order = 0)]
public class CreateKeyEditor : ScriptableObject
{
    public string keyId;
    public string keyName;
    [Space(10)]
    public int keyValue;
    public float keyWeight;
    [Space(10)]
    public AudioClip useSound;
    public AudioClip pickupSound;
    public AudioClip putdownSound;
    [Space(10)]
    public Object script;
    public GameObject prefabModel;
    

}