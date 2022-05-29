using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLW_Car_movement : MonoBehaviour
{
    float X;
    float Y;
    float Z;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        X = 0;
        Y = 0;
        Z = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        X = X + 1;
        
        transform.Rotate(1, Y, Z);
        
    }
}
