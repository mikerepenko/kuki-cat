using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawn : MonoBehaviour {
       
    //public GameObject Obstacle;
    //private GameObject visibleObject;
    public float timer;
    public ScrollMoney scrollMoney1;
    public ScrollMoney scrollMoney2;
    public ScrollMoney scrollMoney3;

    void Start()
    {
        /*if (visibleObject == null)
        {
            transform.position = new Vector3(21f, -1.14f, transform.position.z);
            visibleObject = Instantiate(Obstacle, transform.position, transform.rotation);
        }*/
    }

    void FixedUpdate () {
        timer += Time.deltaTime;


        if (/*visibleObject == null &&*/ timer >= 2)
        {
            scrollMoney1.StartScroll1();
            scrollMoney2.StartScroll2();
            scrollMoney3.StartScroll3();

            /*transform.position = new Vector3(20.96f, -1.14f, transform.position.z);
            visibleObject = Instantiate(Obstacle, transform.position, transform.rotation);*/
        }
        /*Спавн птицы
        if (visiblebird == null && timer >= 2)
        {
            transform.position = new Vector3(50f, 0.43f, transform.position.z);
            visiblebird = Instantiate(bird, transform.position, transform.rotation);
        }*/
        if (timer >= 2)
        timer = 0;        
    }
}
