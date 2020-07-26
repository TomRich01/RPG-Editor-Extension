using UnityEngine;

[CreateAssetMenu(fileName = "Magic Effect", menuName = "Fantasy Data/Magic/Magic Effect", order = 4)]
public class CreateMagicEffectEditor : ScriptableObject
{
    public string MagicEffectId;
    public string MagicEffectName;
    [TextArea]
    public string MagicEffectDescription;
    [Space(10)]
    public GameObject spellObject;
    public ParticleSystem spellParticle;
    [Space(10)]
    public bool fire;
    public bool ice;
    public bool earth;
    public bool wind;


}
 