using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Wheel_2_scr : MonoBehaviour
{
    float X;
    float Y;
    float Z;
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

        transform.Rotate(Time.deltaTime * 50, Y, Z);
    }
}
