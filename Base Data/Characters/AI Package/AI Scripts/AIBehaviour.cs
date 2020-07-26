
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AIBehaviour : MonoBehaviour { 


    
    
    public Transform goal;
    public Transform goal1;
    public Humanoid_Editor humanoid_editor;
    public NavMeshAgent agent;
    public WorldClock clock;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        if (humanoid_editor != null)
        {
            switch (Humanoid_Editor.JobType.beggar)
            {
                case Humanoid_Editor.JobType.beggar:
                    
                    if (clock.countDown == 250.0f)
                    {
                         agent.destination = goal.position;
                       
                        

                    }

                    if (clock.countDown == 200.0f)
                    {

                        agent.destination = goal1.position;

                    }
                    break;
            }
        }
    }
}
