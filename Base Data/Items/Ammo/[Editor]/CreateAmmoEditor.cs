using UnityEngine;

[CreateAssetMenu(fileName = "Ammo", menuName = "Fantasy Data/Items/Ammo", order = 2)]
public class CreateAmmoEditor : ScriptableObject
{
    public string prefabId;
    public string prefabName;
    [TextArea]
    public string description;
    [Space(10)]
    public int ammoValue;
    public float ammoWeight;
    [Space(10)]
    public AudioClip useSound;
    public AudioClip pickupSound;
    public AudioClip putdownSound;
    [Space(10)]
    public ParticleSystem particle;
    public Object script;
    public GameObject prefabModel;
    [Space(10)]
    public bool bolt;
    public bool arrow;
    public bool playable;

    

}