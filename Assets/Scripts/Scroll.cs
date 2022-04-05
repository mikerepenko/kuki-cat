using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float speedBack;
    public int isScroll;

    void Start()
    {
        if (gameObject.name == "Scroll")
            isScroll = 1;
        else if (gameObject.name == "ScrollCar")
            isScroll = 2;
        else if (gameObject.name == "ScrollPlane")
            isScroll = 3;
        else if (gameObject.name == "ScrollClothes")
            isScroll = 4;
    }
    void Update()
    {
        if (isScroll == 1)
        {
            if (PlayerPrefs.GetInt("isScroll") == 1)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0.7f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScroll") == 2)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -7.88f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScroll") == 3)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -17.67f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScroll") == 4)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -27.94f, transform.position.z), speedBack * Time.deltaTime);
        }
        else if (isScroll == 2)
        {
            if (PlayerPrefs.GetInt("isScrollCar") == 1)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0.7f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollCar") == 2)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -7.88f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollCar") == 3)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -17.67f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollCar") == 4)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -27.94f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollCar") == 5)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -38.2f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollCar") == 6)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -48.61f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollCar") == 7)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -58.9f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollCar") == 8)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -69.17f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollCar") == 9)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -79.29f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollCar") == 10)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -89.74f, transform.position.z), speedBack * Time.deltaTime);
        }
        else if(isScroll == 3)
        {
            if (PlayerPrefs.GetInt("isScrollPlane") == 1)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0.7f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollPlane") == 2)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -7.88f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollPlane") == 3)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -17.67f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollPlane") == 4)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -27.94f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollPlane") == 5)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -38.2f, transform.position.z), speedBack * Time.deltaTime);
        }
        else if (isScroll == 4)
        {
            if (PlayerPrefs.GetInt("isScrollClothes") == 1)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0.7f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollClothes") == 2)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -7.88f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollClothes") == 3)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -17.67f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollClothes") == 4)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -27.94f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScrollClothes") == 5)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -38.2f, transform.position.z), speedBack * Time.deltaTime);
        }
    }
}