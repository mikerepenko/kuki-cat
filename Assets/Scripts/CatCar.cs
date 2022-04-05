using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCar : MonoBehaviour {

	void Start () {
        if (PlayerPrefs.GetInt("buyCar") == 2)
            if (PlayerPrefs.GetInt("BuySave12") == 1)
                transform.localPosition = new Vector3(-0.72f, 0.2f, 1f);
            else
                transform.localPosition = new Vector3(-0.14f, 0.33f, 1f);

        if (PlayerPrefs.GetInt("buyCar") == 3)
            if (PlayerPrefs.GetInt("BuySave13") == 1)
                transform.localPosition = new Vector3(-0.4f, 0.04f, 1f);
            else
                transform.localPosition = new Vector3(-0.14f, 0.33f, 1f);

        if (PlayerPrefs.GetInt("buyCar") == 4)
            if (PlayerPrefs.GetInt("BuySave14") == 1)
                transform.localPosition = new Vector3(-0.4f, 0.04f, 1f);
            else
                transform.localPosition = new Vector3(-0.14f, 0.33f, 1f);

        if (PlayerPrefs.GetInt("buyCar") == 5)
            if (PlayerPrefs.GetInt("BuySave15") == 1)
                transform.localPosition = new Vector3(-0.09f, -0.11f, 1f);  
            else
                transform.localPosition = new Vector3(-0.14f, 0.33f, 1f);

        if (PlayerPrefs.GetInt("buyCar") == 6)
            if (PlayerPrefs.GetInt("BuySave16") == 1)
                transform.localPosition = new Vector3(-0.09f, -0.11f, 1f);
            else
                transform.localPosition = new Vector3(-0.14f, 0.33f, 1f);

        if (PlayerPrefs.GetInt("buyCar") == 7)
            if (PlayerPrefs.GetInt("BuySave17") == 1)
                transform.localPosition = new Vector3(-0.21f, 0.32f, 1f);
            else
                transform.localPosition = new Vector3(-0.14f, 0.33f, 1f);
        if (PlayerPrefs.GetInt("buyCar") == 8)
            if (PlayerPrefs.GetInt("BuySave18") == 1)
                gameObject.SetActive(false);
            else
                transform.localPosition = new Vector3(-0.14f, 0.33f, 1f);

        if (PlayerPrefs.GetInt("buyCar") == 1)
            transform.localPosition = new Vector3(-0.14f, 0.33f, 1f);
    }

	void Update () {
		
	}
}
