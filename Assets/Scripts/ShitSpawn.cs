using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShitSpawn : MonoBehaviour {

    public GameObject Obstacle;
    private GameObject visibleObject;
    public float timer = 2;
    private bool isCar;

    public ScrollShit scrollShit1;
    public ScrollShit scrollShit2;
    public ScrollShit scrollShit3;

    public GameObject Plane;
    private GameObject visiblePlane;

    public GameObject milk;
    private GameObject visibleMilk;

    private int rund;

    void Start()
    {
        /*if (PlayerPrefs.GetInt("FirstCar") != 1)
            isCar = true;
        else
            isCar = false;
        //При первом запуске игры
        //if (isCar)*/
        rund = Random.Range(1, 4);
        switch (rund)
        {
            case 1:
                if (visibleObject == null)
                {
                    transform.position = new Vector3(16f, transform.position.y, transform.position.z);
                    visibleObject = Instantiate(Obstacle, transform.position, transform.rotation);
                }
                break;
            case 2:
                if (visiblePlane == null)
                {
                    transform.position = new Vector3(24f, transform.position.y, transform.position.z);
                    visiblePlane = Instantiate(Plane, transform.position, transform.rotation);
                }
                break;
            case 3:
                if (visibleMilk == null)
                {
                    transform.position = new Vector3(24f, transform.position.y, transform.position.z);  
                    visibleMilk = Instantiate(milk, transform.position, transform.rotation);
                }
                break;
        }
        //Возвращаем координаты SpawnShit
        transform.position = new Vector3(11.9f, transform.position.y, transform.position.z);
    }

    void FixedUpdate() {
        timer += Time.deltaTime;
        if (timer >=2)
        {
            scrollShit1.StartScroll1();
            scrollShit2.StartScroll2();
            scrollShit3.StartScroll3();
        }
        /*if (visibleObject == null && timer >= 2f)
        {
            transform.position = new Vector3(217f, transform.position.y, transform.position.z);
            visibleObject = Instantiate(Obstacle, transform.position, transform.rotation);
        }      
        if (visiblePlane == null && timer >= 2f)
        {
            transform.position = new Vector3(300f, transform.position.y, transform.position.z);
            visiblePlane = Instantiate(Plane, transform.position, transform.rotation);
        }
        if (visibleMilk == null && timer >= 2f)
        {
            transform.position = new Vector3(104.5f, transform.position.y, transform.position.z);
            visibleMilk = Instantiate(milk, transform.position, transform.rotation);
        }*/
        if (timer >= 2f)
            timer = 0;
    }
}
