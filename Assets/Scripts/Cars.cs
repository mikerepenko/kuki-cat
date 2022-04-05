using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cars : MonoBehaviour
{
    public float timerCar;
    public float jump;
    public float speedObstracles;
    public AudioSource soundCar;
    public AudioSource crash;
    public AudioSource coins;  
    Rigidbody2D jumpCar;
    public bool isCar;
    public GameManager GameManager;
    public Wheels Wheels;
    public Sprite car1, car2, car3, car4, car5, car6, car7, car8, car9;
    private int hp;
    public HP hpControl;
    private int hpFix;
    public Timer timer;

    void Start()
    {
        isCar = false;
        jumpCar = GetComponent<Rigidbody2D>();

        if (PlayerPrefs.GetInt("buyCar") == 2)
            if (PlayerPrefs.GetInt("BuySave12") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = car2;
                hp = 3;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = car1;
                hp = 2;
            }

        if (PlayerPrefs.GetInt("buyCar") == 3)
            if (PlayerPrefs.GetInt("BuySave13") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = car3;
                hp = 4;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = car1;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 4)
            if (PlayerPrefs.GetInt("BuySave14") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = car4;
                hp = 5;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = car1;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 5)
            if (PlayerPrefs.GetInt("BuySave15") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = car5;
                hp = 5;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = car1;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 6)
            if (PlayerPrefs.GetInt("BuySave16") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = car6;
                hp = 100;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = car1;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 7)
            if (PlayerPrefs.GetInt("BuySave17") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = car7;
                hp = 100;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = car1;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 8)
            if (PlayerPrefs.GetInt("BuySave18") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = car8;
                hp = 100;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = car1;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 9)
            if (PlayerPrefs.GetInt("BuySave19") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = car9;
                hp = 5;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = car1;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 1)
        {
            GetComponent<SpriteRenderer>().sprite = car1;
            hp = 2;
        }


        hpFix = hp;
    }
    public void CarStart()
    {
        isCar = true;
        hpControl.StartHp();
        hp = hpFix;
        timer.StartTC();
    }
    public void CarStop()
    {
        isCar = false;
        hpControl.StopHp();
        soundCar.enabled = false;
    }
    void Update()
    {
        if (isCar == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-5.15f, transform.position.y, transform.position.z), speedObstracles * Time.deltaTime);
            //Таймер
            /*timerCar += Time.deltaTime;
            if (timerCar >= 24.2f)
            {
                CarStop();
                timerCar = 0;
                    
            }*/
            //if (PlayerPrefs.GetInt("Stop") == 1)
                if (Input.GetKeyDown(KeyCode.Mouse0) && Wheels.isJump == true)
                {
                    jumpCar.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
                    Wheels.WheelsFalse();
                }
            if (hp == 0)
            {
                CarStop();
                timerCar = 0;
            }
        }
        else
        {            
            transform.position = new Vector3(-13.65f, transform.position.y, transform.position.z);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "money")
        {
            coins.GetComponent<AudioSource>().Play();
            //Destroy(other.gameObject);
            GameManager.AddMoney(5);                     
        }
        /*if (other.gameObject.tag == "milk") ;
            //Destroy(other.gameObject);

            if (other.gameObject.tag == "Finish") ;
                //Destroy(other.gameObject);
                if (other.gameObject.tag == "plane") ;
            //Destroy(other.gameObject);*/
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "tube")
        {
            Destroy(col.gameObject);
            crash.Play();
            if (hp > 0)
            {
                hp--;
                if (hp == 4)
                    hpControl.FourHp();
                if (hp == 3)
                    hpControl.ThreeHp();
                if (hp == 2)
                    hpControl.TwoHp();
                if (hp == 1)
                    hpControl.OneHp();
                if (hp == 0)
                    hpControl.enabled = false;

            }
        }
    }
}
