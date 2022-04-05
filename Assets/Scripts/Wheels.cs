using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wheels : MonoBehaviour {

    public float SpeedWheel;
    public bool isJump;
    public Sprite wheel1, wheel2, wheel3, wheel4, wheel5, wheel6, wheel7, wheel8, wheel9;
    private int numberO;

    void Start()
    {
        if (gameObject.name == "wheelfront" || gameObject.name == "wheelback")
        {
            if (PlayerPrefs.GetInt("buyCar") == 2)
                if (PlayerPrefs.GetInt("BuySave12") == 1)
                    GetComponent<SpriteRenderer>().sprite = wheel2;
                else
                    GetComponent<SpriteRenderer>().sprite = wheel1;

            if (PlayerPrefs.GetInt("buyCar") == 3)
                if (PlayerPrefs.GetInt("BuySave13") == 1)
                    GetComponent<SpriteRenderer>().sprite = wheel3;
                else
                    GetComponent<SpriteRenderer>().sprite = wheel1;

            if (PlayerPrefs.GetInt("buyCar") == 4)
                if (PlayerPrefs.GetInt("BuySave14") == 1)
                    GetComponent<SpriteRenderer>().sprite = wheel4;
                else
                    GetComponent<SpriteRenderer>().sprite = wheel1;

            if (PlayerPrefs.GetInt("buyCar") == 5)
                if (PlayerPrefs.GetInt("BuySave15") == 1)
                    GetComponent<SpriteRenderer>().sprite = wheel5;
                else
                    GetComponent<SpriteRenderer>().sprite = wheel1;

            if (PlayerPrefs.GetInt("buyCar") == 6)
                if (PlayerPrefs.GetInt("BuySave16") == 1)
                    GetComponent<SpriteRenderer>().sprite = wheel6;
                else
                    GetComponent<SpriteRenderer>().sprite = wheel1;

            if (PlayerPrefs.GetInt("buyCar") == 7)
                if (PlayerPrefs.GetInt("BuySave17") == 1)
                    GetComponent<SpriteRenderer>().sprite = wheel7;
                else
                    GetComponent<SpriteRenderer>().sprite = wheel1;

            if (PlayerPrefs.GetInt("buyCar") == 8)
                if (PlayerPrefs.GetInt("BuySave18") == 1)
                {
                    GetComponent<SpriteRenderer>().sprite = wheel8;
                    transform.position = new Vector3(transform.position.x, transform.position.y, 1f);
                }
                else
                    GetComponent<SpriteRenderer>().sprite = wheel1;

            if (PlayerPrefs.GetInt("buyCar") == 9)
                if (PlayerPrefs.GetInt("BuySave19") == 1)
                {
                    GetComponent<SpriteRenderer>().sprite = wheel9;            
                }
                else
                    GetComponent<SpriteRenderer>().sprite = wheel1;

            if (PlayerPrefs.GetInt("buyCar") == 1)
                GetComponent<SpriteRenderer>().sprite = wheel1;
        }
        else
            numberO = 3;
        if (gameObject.name == "wheelfront")
            numberO = 1;
        if (gameObject.name == "wheelback")
            numberO = 2;

    }

    void Update()
    {
        transform.Rotate(0, 0, SpeedWheel * Time.deltaTime / 0.02f);
        //Возвращение колес после столкновения

        if (gameObject.transform.localPosition.y >= -0.36f)
        {
            if (numberO == 1)
                transform.localPosition = new Vector3(1.597f, -0.8f, -1f);
            if (numberO == 2)
                transform.localPosition = new Vector3(-1.58f, -0.8f, -1f);
        }
    }

    public void WheelsFalse()
    {
        isJump = false;
    }
    
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "platf")
            isJump = true;
    }    
}
