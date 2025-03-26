
using UnityEngine;
using System;
using Random = System.Random;
using UnityEngine.UI;

public class CubeTransform : MonoBehaviour
{
    
    private Transform point;
    public int l; // макс дальность точек по координатам
    public int n;//количество точек
    int k = 0;
    private Vector3[] vec;
    private bool forward = true;
    public Text distanceText;
    private float distanceFloat;
  
    void Start()
    {
        vec = SetVecMassive(n);
        point = GameObject.Find("GameObject").GetComponent<Transform>();
        
    }
     private Vector3[] SetVecMassive(int lenght)
    {
        Random rnd = new Random();
        Vector3[] arr = new Vector3[lenght];
        for (int i = 0; i < lenght; i++)
        {
            arr[i].Set(rnd.Next(-l, l), rnd.Next(-l, l), rnd.Next(-l, l));
        }

        return arr;
    }

    // Update is called once per frame
    void Update()
    {

        /* if (transform.position == vec[k] && forward)  k++;
         if (k == n - 1) forward = false;
         if (transform.position == vec[k] && forward==false) k--;
         if (k == 0) forward = true;
         distanceFloat = Vector3.Distance(transform.position, vec[k]);
         distanceToNext.text = $"{Mathf.Round(distanceFloat)}";
         transform.position = Vector3.MoveTowards(transform.position, vec[k], Time.deltaTime);*/
        if (distanceFloat == 0 && forward)
        {
            
            k++;
            transform.LookAt(vec[k]);
        }
        if (k == n - 1) forward = false;
        if (distanceFloat == 0 && forward == false)
        {
            
            k--;
            transform.LookAt(vec[k]);
        }
        if (k == 0) forward = true;
      
        distanceFloat = Vector3.Distance(transform.position, vec[k]);
        distanceText.text = $"{Mathf.Round(distanceFloat)}";
        transform.position = Vector3.MoveTowards(transform.position, vec[k], Time.deltaTime);


    }
}
