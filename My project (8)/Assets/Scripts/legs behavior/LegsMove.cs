using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsMove : MonoBehaviour
{
    [SerializeField] private Transform leg1;
    [SerializeField] private Transform leg2;
    [SerializeField] RunnersScript isRunning;
    // Start is called before the first frame update
    void Start()
    {
        leg1.Rotate(90, 0, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning.k == 0)
        {
            leg1.Rotate(1, 0, 0);
            leg2.Rotate(1, 0, 0);

        }
        
        

    }
}
