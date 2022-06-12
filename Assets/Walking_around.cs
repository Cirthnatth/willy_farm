using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking_around : MonoBehaviour
{
    bool iswalking;
    bool isrunning;
    bool iseating;
    bool isidle;
    bool isturnhead;
    string Connectioner;
    private Animator Chickin;
    int delaytimer;
    int Rng_action = 0;
    int rng_time;
    public float chicken_walking;
    // Start is called before the first frame update
    void Start()
    {
        Chickin = GetComponent<Animator>();
        delaytimer = 0;
        Rng_action = Random.Range(1, 5);
        rng_time = Random.Range(450, 750);

    }

    // Update is called once per frame
    void Update()
    {
        
        delaytimer = delaytimer + 1;
        if(delaytimer >= rng_time)
        {
            Rng_action = Random.Range(1, 5);
            delaytimer = 0;
        }
        
        if (Rng_action == 1)
        {
            isidle = true;
            iseating = false;
            isrunning = false;
            isturnhead = false;
            iswalking = false;
        }
        else if(Rng_action == 2)
        {
            isidle = false;
            iseating = true;
            isrunning = false;
            isturnhead = false;
            iswalking = false;
        }
        else if(Rng_action == 3)
        {
            isidle = false;
            iseating = false;
            isrunning = true;
            isturnhead = false;
            iswalking = false;
        }
        else if (Rng_action == 4)
        {
            isidle = false;
            iseating = false;
            isrunning = false;
            isturnhead = true;
            iswalking = false;
        }
        else if (Rng_action == 5)
        {
            isidle = false;
            iseating = false;
            isrunning = false;
            isturnhead = false;
            iswalking = true;
        }

        if(isidle == true)
        {
            Chickin.Play("Idle");
        }
        if(iseating == true)
        {
            Chickin.Play("Eat");
        }
        if (isrunning == true)
        {
            Chickin.Play("Run In Place");
            this.transform.Translate(0, 0, chicken_walking * (2));
        }
        if (isturnhead == true)
        {
            Chickin.Play("Turn Head");
        }
        if (iswalking == true)
        {
            Chickin.Play("Walk In Place");
            this.transform.Translate(0, 0, chicken_walking);
        }

    }
}
