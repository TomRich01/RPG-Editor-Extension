using UnityEngine;

[CreateAssetMenu(fileName = "Magic Effect", menuName = "Fantasy Data/Magic/Magic Effect", order = 4)]
public class MagicEffect : ScriptableObject
{
    public string MagicEffectName;
    [TextArea]
    public string MagicEffectDescription;
    [Space(10)]
    public ParticleSystem spellParticle;


}
 