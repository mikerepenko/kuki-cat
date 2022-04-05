using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollShit : MonoBehaviour {

    public float speedObstracles;
    public bool isScroll;
    private int numShit;

    public void StartScroll1()
    {
        isScroll = true;
    }
    public void StopScroll1()
    {
        isScroll = false;
        transform.position = new Vector3(199f, transform.position.y, transform.position.z);
    }
    public void StartScroll2()
    {
        isScroll = true;
    }
    public void StopScroll2()
    {
        isScroll = false;
        transform.position = new Vector3(299f, transform.position.y, transform.position.z);
    }
    public void StartScroll3()
    {
        isScroll = true;
    }
    public void StopScroll3()
    {
        isScroll = false;
        transform.position = new Vector3(105.5f, transform.position.y, transform.position.z);
    }
    void Start()
    {
        if (gameObject.name == "Shit1")
            numShit = 1;
        if (gameObject.name == "Shit2")
            numShit = 2;
        if (gameObject.name == "Shit3")
            numShit = 3;


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "cat")
        {
            if (numShit == 1)
            {
                //CarShit
                transform.position = new Vector3(199f, transform.position.y, transform.position.z);
                isScroll = false;
            }
            if (numShit == 2)
            {
                //PlaneShit
                transform.position = new Vector3(299f, transform.position.y, transform.position.z);
                isScroll = false;
            }
            if (numShit == 3)
            {
                //MilkShit
                transform.position = new Vector3(105.5f, transform.position.y, transform.position.z);
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
                if (numShit == 1)
                {
                    transform.position = new Vector3(199f, transform.position.y, transform.position.z);
                    isScroll = false;
                }
                if (numShit == 2)
                {
                    transform.position = new Vector3(299f, transform.position.y, transform.position.z);
                    isScroll = false;
                }
                if (numShit == 3)
                {
                    transform.position = new Vector3(105.5f, transform.position.y, transform.position.z);
                    isScroll = false;
                }

            }
        }
    }
}
