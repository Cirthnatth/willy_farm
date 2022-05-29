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
    // Start is called before the first frame update
    void Start()
    {
        Chickin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        int Rng_action;
        Rng_action = Random.Range(1, 5);
        if(Rng_action == 1)
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
        }
        if (isturnhead == true)
        {
            Chickin.Play("Turn Head");
        }
        if (iswalking == true)
        {
            Chickin.Play("Walk In Place");
        }
        StartCoroutine(Delay());
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(10000);
    }
}
