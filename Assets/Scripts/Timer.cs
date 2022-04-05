using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public Cars cars;
    public Cats cats;
    public bool carTime, catTime;
    public float timer, catTimer;

    public void StartTC()
    {
        carTime = true;
    }

    public void StopTC()
    {
        carTime = false;
    }

    public void StartTM()
    {
        catTime = true;
    }

    public void StopTM()
    {
        catTime = false;
    }

    void Update () {
        if (carTime)
            timer += Time.deltaTime;
        if (timer > 16.5)
        {
            cars.CarStop();
            StopTC();
            timer = 0;
        }
        if (catTime)
            catTimer += Time.deltaTime;
        if (catTimer > 5.35)
        {
            cats.MilkStop();
            StopTM();
            catTimer = 0;
        }
    }
}
