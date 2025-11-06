using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScheduleBox : MonoBehaviour
{

    public Color BoxColor = new Color(0, 0, 0, 5f);
    public interactionType interactType;
    public enum interactionType
    {
        none = 0,
        sit = 1,
        chopWood = 2,
        idleShop = 3,
        farmLand = 4,
        sleep = 5,
        beg = 6,
        idleStand = 7,
        idleTalk = 8,
        heal = 9
    }


    void OnDrawGizmos()
    {


                Gizmos.color = BoxColor;
                    Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
        for (int i = 0; i < transform.childCount; i++)
        {
            int j = GetNextIndex(i);
            Gizmos.DrawSphere(GetWaypoint(i), waypointGizmoRadius);
            Gizmos.DrawLine(GetWaypoint(i), GetWaypoint(j));
        }



    }

    const float waypointGizmoRadius = 0.3f;

    public int GetNextIndex(int i)
    {

        if (i + 1 == transform.childCount)
        {
            return 0;
        }
        return i + 1;

    }




    public Vector3 GetWaypoint(int i)
    {
        return transform.GetChild(i).position;
    }
}
