using UnityEngine;
public class AnimatorMirrorSync : MonoBehaviour
{
    public Animator master; // full body
    public Animator slave;  // FP arms
    public string[] boolParams, intParams, floatParams;
    void Awake()
    {
        for (int l = 0; l < Mathf.Min(master.layerCount, slave.layerCount); l++)
        {
            var s = master.GetCurrentAnimatorStateInfo(l);
            slave.Play(s.fullPathHash, l, s.normalizedTime);
            slave.SetLayerWeight(l, master.GetLayerWeight(l));
        }
        CopyParams();
    }
    void LateUpdate()
    {
        CopyParams();
        for (int l = 0; l < Mathf.Min(master.layerCount, slave.layerCount); l++)
        {
            var s = master.GetCurrentAnimatorStateInfo(l);
            slave.SetLayerWeight(l, master.GetLayerWeight(l));
            slave.Play(s.fullPathHash, l, s.normalizedTime);
        }
    }
    void CopyParams()
    {
        foreach (var p in boolParams) slave.SetBool(p, master.GetBool(p));
        foreach (var p in intParams) slave.SetInteger(p, master.GetInteger(p));
        foreach (var p in floatParams) slave.SetFloat(p, master.GetFloat(p));
    }
}
