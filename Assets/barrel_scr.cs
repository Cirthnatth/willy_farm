using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel_scr : MonoBehaviour
{
    public bool existance;
    public GameObject coro;
    public GameObject boro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (existance == true) 
        {
            boro.transform.position = coro.transform.position;
            coro.SetActive(true);
            boro.SetActive(false);
        }
        else
        {
            coro.transform.position = boro.transform.position;
            coro.SetActive(false);
            boro.SetActive(true);
        }
    }
}
