using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBox : MonoBehaviour
{

    
    public interactionType interactType;
    public enum interactionType
    {
        idleTalk = 0,
        sit = 1,
        chopWood = 2,
        idleShop = 3,
        farmLand = 4,
        sleep = 5,
        beg = 6,
        idleStand = 7
    }
    void OnDrawGizmos()
    {

       
                    Gizmos.color = new Color(1, 0, 0, 0.5f);
                    Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));




    }
}
