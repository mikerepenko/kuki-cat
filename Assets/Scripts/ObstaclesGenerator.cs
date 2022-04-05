using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
    public GameObject Obstacle;
    public GameObject box;
    public GameObject lamp;
    public GameObject banka;
    public GameObject sliwki;

    private GameObject visibleObject;
    public float timerBox;
    public float timerMilk;
    public float timerMoney;
    public float timerShit;
    private int rund;

    void Start()
    {
        timerBox = 2;
        timerMilk = 2;
        timerMoney = 2;
        timerShit = 2;
       
    }
    void FixedUpdate()
    {
        /* if(gameObject.name == "ShitSpawn")
        if(PlayerPrefs.GetInt("FirstCar") != 1)
        {
                if (visibleObject == null)
                {
                    transform.position = new Vector3(55f, transform.position.y, transform.position.z);
                    visibleObject = Instantiate(Obstacle, transform.position, transform.rotation);
                }                
        }
        if (gameObject.name == "BoxSpawnFalse")
        {
            timerBox += Time.deltaTime;            
            //При условие что нет другого объекта
            
            if (visibleObject == null && timerBox >= 2f)
            {
                transform.position = new Vector3(9.96f, transform.position.y, transform.position.z);
                visibleObject = Instantiate(Obstacle, transform.position, transform.rotation);
            }
            if (timerBox >= 2f)
                timerBox = 0;
        }
        
            if (gameObject.name == "MilkSpawn")
        {
            timerMilk += Time.deltaTime;
            //При условие что нет другого объекта
            if (visibleObject == null && timerMilk >= 2f)
            {
                transform.position = new Vector3(156f, transform.position.y, transform.position.z);
                visibleObject = Instantiate(Obstacle, transform.position, transform.rotation);
            }
            if (timerMilk >= 2f)
                timerMilk = 0;
        }

        
        if (gameObject.name == "MoneySpawn")
        {
            timerMoney += Time.deltaTime;
            //При условии что нет другого объекта
            if (visibleObject == null && timerMoney >= 2)
            {
                transform.position = new Vector3(25.96f, transform.position.y, transform.position.z);
                visibleObject = Instantiate(Obstacle, transform.position, transform.rotation);
            }
            if (timerMoney >= 2)
                timerMoney = 0;
        }

        
        if (gameObject.name == "ShitSpawn")
        {
            timerShit += Time.deltaTime;
            //При условии что нет другого объекта
            if (visibleObject == null && timerShit >= 2f)
            {
                transform.position = new Vector3(205f, transform.position.y, transform.position.z);
                visibleObject = Instantiate(Obstacle, transform.position, transform.rotation);
            }
            if (timerShit >= 2f)
                timerShit = 0;
        }*/
    }
}