using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    private bool isRocket;
    public float speedRocket;
    public float posR;
    public AudioSource ballDown;

    public void StopRocket()
    {
        isRocket = false;
    }

    void Start()
    {

    }

    public void PositionRocket(float posP)
    {
        posR = posP;
        isRocket = true;   
    }

    void Update()
    {
        if (isRocket)
        {
            transform.position = new Vector3(transform.position.x, posR, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-9.96f, posR, transform.position.z), speedRocket * Time.deltaTime);
            ballDown.enabled = true;
            if (gameObject.transform.position.x < -9.90f)
            {
                ballDown.enabled = false;
                isRocket = false;
                transform.position = new Vector3(11f, posR, transform.position.z);
            }
        }
        else
        {
            transform.position = new Vector3(11f, posR, transform.position.z);
            ballDown.enabled = false;
        }
    }
}
