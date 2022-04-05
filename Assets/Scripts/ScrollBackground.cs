using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour {

    public float speedBack;

	void Start () {
    }
	
	void Update () {
        /*if (gameObject.name == "CityDay1" || gameObject.name == "CityDay2")
        {         
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-19.50f, transform.position.y, transform.position.z), speedBack * Time.deltaTime);
            if (gameObject.transform.position.x < -19.45f)
                   transform.position = new Vector3(21.10f, transform.position.y, transform.position.z);
        }
        if (gameObject.name == "SkyDay1" || gameObject.name == "SkyDay2")
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-20.27f, transform.position.y, transform.position.z), speedBack * Time.deltaTime);
            if (gameObject.transform.position.x < -20.25f)
                transform.position = new Vector3(20.5f, transform.position.y, transform.position.z);
        }
        if(gameObject.name == "SkyDayt1" || gameObject.name == "SkyDayt2")
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-19.50f, transform.position.y, transform.position.z), speedBack * Time.deltaTime);
            if (gameObject.transform.position.x < -19.45f)
                transform.position = new Vector3(21.10f, transform.position.y, transform.position.z);
        }
        if(gameObject.name == "Tree1" || gameObject.name == "Tree2")
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-18.30f, transform.position.y, transform.position.z), speedBack * Time.deltaTime);
            if (gameObject.transform.position.x < -18.21f)            
                transform.position = new Vector3(19.13f, transform.position.y, transform.position.z);              
        }
        if(gameObject.name == "SkyMenu1" || gameObject.name == "SkyMenu2")
        {
            //speedScroll += Time.deltaTime;
            //transform.position = new Vector2(-speedBack, 0);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-19.5f, transform.position.y, transform.position.z), speedBack * Time.deltaTime);
            //transform.Translate(new Vector3(speedScroll * Time.deltaTime, transform.position.y, transform.position.z));
            //transform.Translate(Vector3.left * 2 * Time.deltaTime);
            if (gameObject.transform.position.x < -19.45f)
                transform.position = new Vector3(20.5f, transform.position.y, transform.position.z);
        }
        if (gameObject.name == "SkyNight1" || gameObject.name == "SkyNight2")
        {
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(-19.50f, transform.position.y, transform.position.z), speedBack * Time.deltaTime);
            transform.Translate(Vector3.left * 3 * Time.deltaTime);
            if (gameObject.transform.position.x < -17.33008f)
                transform.position = new Vector3(17.8f, transform.position.y, transform.position.z);
        }
        //Скрол для магазина
        if (gameObject.name == "Scroll")
        {
            if(PlayerPrefs.GetInt("isScroll") == 1)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x , 0.7f, transform.position.z), speedBack * Time.deltaTime);
            if (PlayerPrefs.GetInt("isScroll") == 2)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -7.7f, transform.position.z), speedBack * Time.deltaTime); 
            if (PlayerPrefs.GetInt("isScroll") == 3)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -17.5f, transform.position.z), speedBack * Time.deltaTime);

        }
        if (gameObject.name == "SkyShop1" || gameObject.name == "SkyShop2")
        {
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(-19.5f, transform.position.y, transform.position.z), speedBack * Time.deltaTime);
            transform.Translate(Vector3.left * 2 * Time.deltaTime);
            if (gameObject.transform.position.x < -19.45f)
                transform.position = new Vector3(21f, transform.position.y, transform.position.z);
        }*/
    }
}
