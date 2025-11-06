using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class boxgiz : MonoBehaviour
{
    public Color newColor = new Color(0.3f, 0.4f, 0.6f, 0.3f);

    void OnDrawGizmos()
    {
        // Draw a semitransparent blue cube at the transforms position
        Gizmos.color = newColor;
        Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
        
    }
}