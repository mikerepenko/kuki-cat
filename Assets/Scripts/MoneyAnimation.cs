using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyAnimation : MonoBehaviour {

    public float speed;
    private int numberButtons;

    void Start()
    {
        if (gameObject.name == "Ads")
            numberButtons = 1;
        else
            numberButtons = 2;

    }

    void Update()
    {
        if (PlayerPrefs.GetInt("isAnim") != 1)
        {
            if (numberButtons == 2)
                if (gameObject.transform.position.x != 2f)
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-6.94f, transform.position.y, transform.position.z), speed * Time.deltaTime);
            if (numberButtons == 1)
                if (gameObject.transform.position.x != 1f)
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(0f, transform.position.y, transform.position.z), speed * Time.deltaTime);
        }
        else
        {
          if (numberButtons == 2)
            transform.position = new Vector3(-15f, transform.position.y, transform.position.z);
          if (numberButtons == 1)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(1.4f, transform.position.y, transform.position.z), speed * Time.deltaTime);
          }
    }
}
