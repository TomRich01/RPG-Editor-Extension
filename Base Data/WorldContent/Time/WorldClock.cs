
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class WorldClock : MonoBehaviour
    {
    public float countMax = 400.0f;
    public float countDown = 400.0f;
    public float waitCount = 0.0f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
            if (countDown > waitCount)
            {
            countDown -= Time.deltaTime;
           
            }
            if (countDown == waitCount)
        {
            countDown = countMax;
        }

        }


    }


