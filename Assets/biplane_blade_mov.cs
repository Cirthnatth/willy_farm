using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biplane_blade_mov : MonoBehaviour
{
    float X;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        X = X + 1;
        transform.Rotate(X, 0, 0);
    }
}
