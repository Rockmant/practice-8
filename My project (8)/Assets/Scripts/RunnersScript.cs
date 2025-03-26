using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnersScript : MonoBehaviour
{
    public Transform[] runner;
    public Transform stick;
    public int k =0;
    int j = 1;
    private float distance;
    public float passDistance;

    void Start()
    {
        runner[k].LookAt(runner[j].position);
       
    }

    // Update is called once per frame
    void Update()
    {
        
        distance = Vector3.Distance(runner[k].position, runner[j].position);
        if (distance < passDistance )
        {
            if (j == 0) k = -1;
            k++;

            j = k + 1;
            if (k == 3) j = 0;
            stick.SetParent(runner[k]);
            stick.rotation = runner[k].rotation;

            runner[k].LookAt(runner[j].position);

           
            stick.position = runner[k].position;
            
            
        }
        

            runner[k].position = Vector3.MoveTowards(runner[k].position, runner[j].position, Time.deltaTime*3);
        
    }
}
