using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BIplane_mov : MonoBehaviour
{
    public float Biplane_speed_forward;
    public float Biplane_speed_left;
    public float Biplane_speed_right;
    public float Biplane_speed_backward;
    public float Biplane_speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Biplane_speed, 0, 0);
        Movement();
    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.I))
        {
            this.transform.Translate(0, 0, Biplane_speed_forward);
            if (Input.GetKey(KeyCode.J))
            {
                this.transform.Translate(Biplane_speed_left*(-1),0,0);
            }
            if (Input.GetKey(KeyCode.L))
            {
                this.transform.Translate(Biplane_speed_right, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.K))
        {
            this.transform.Translate(0, 0, Biplane_speed_backward * (-1));
            if (Input.GetKey(KeyCode.J))
            {
                this.transform.Translate(Biplane_speed_left * (-1), 0, 0);
            }
            if (Input.GetKey(KeyCode.L))
            {
                this.transform.Translate(Biplane_speed_right, 0, 0);
            }
        }
    }

}
    

