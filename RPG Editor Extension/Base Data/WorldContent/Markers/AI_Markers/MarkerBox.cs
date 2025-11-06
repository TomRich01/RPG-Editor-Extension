using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerBox : MonoBehaviour
{
    public JobType Job;
    public enum JobType
    {
        none = 0,
        navigationPoints = 1,
        interactionAreas = 2
    }
    void OnDrawGizmos()
    {

        switch (Job)
        {
            case JobType.none:
              

                {
                    Gizmos.color = new Color(0, 0, 0, 0.5f);
                    Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));



                }
                break;

            case JobType.navigationPoints:


                {
                    Gizmos.color = new Color(0, 0, 1, 0.5f);
                    Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));



                }
                break;

            case JobType.interactionAreas:
                

                {
                    Gizmos.color = new Color(1, 0, 0, 0.5f);
                    Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));



                }
                break;
        }
               
    }
}

