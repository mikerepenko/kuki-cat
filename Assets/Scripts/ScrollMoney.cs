using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollMoney : MonoBehaviour
{

    public float speedObstracles;
    public bool isScroll;
    private int numMoney;

    public void StartScroll1()
    {
        isScroll = true;
    }
    public void StopScroll1()
    {
        isScroll = false;
        transform.position = new Vector3(23f, transform.position.y, transform.position.z);
    }
    public void StartScroll2()
    {
        isScroll = true;
    }
    public void StopScroll2()
    {
        isScroll = false;
        transform.position = new Vector3(21.5f, transform.position.y, transform.position.z);
    }
    public void StartScroll3()
    {
        isScroll = true;
    }
    public void StopScroll3()
    {
        isScroll = false;
        transform.position = new Vector3(20f, transform.position.y, transform.position.z);
    }
    void Start()
    {
        if (gameObject.name == "Money1")
            numMoney = 1;
        if (gameObject.name == "Money2")
            numMoney = 2;
        if (gameObject.name == "Money3")
            numMoney = 3;


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "cat")
        {
            if (numMoney == 1)
            {
                transform.position = new Vector3(23f, transform.position.y, transform.position.z);
                isScroll = false;
            }
            if (numMoney == 2)
            {
                transform.position = new Vector3(21.5f, transform.position.y, transform.position.z);
                isScroll = false;
            }
            if (numMoney == 3)
            {
                transform.position = new Vector3(20f, transform.position.y, transform.position.z);
                isScroll = false;
            }
        }
    }
    void Update()
    {
        if (isScroll)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-15f, transform.position.y, transform.position.z), speedObstracles * Time.deltaTime);
            if (gameObject.transform.position.x < -14.90f)
            {
                if (numMoney == 1)
                {
                    transform.position = new Vector3(23f, transform.position.y, transform.position.z);
                    isScroll = false;
                }
                if (numMoney == 2)
                {
                    transform.position = new Vector3(21.5f, transform.position.y, transform.position.z);
                    isScroll = false;
                }
                if (numMoney == 3)
                {
                    transform.position = new Vector3(20f, transform.position.y, transform.position.z);
                    isScroll = false;
                }

            }
        }
    }
}
