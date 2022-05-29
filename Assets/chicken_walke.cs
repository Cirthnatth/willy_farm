using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken_walke : MonoBehaviour
{
    public float chicken_front;
    private Animator arnin;
    // Start is called before the first frame update
    void Start()
    {
        arnin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        walker_func();
    }

    void walker_func()
    {


        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.Translate(0, 0, chicken_front*(2));
            arnin.Play("Run In Place");
        }
        else if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.Translate(0, 0, chicken_front);
            arnin.Play("Walk In Place");
        }
        else
        {
            arnin.Play("Idle");
        }

    }
}
