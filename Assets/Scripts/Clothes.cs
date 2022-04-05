using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : MonoBehaviour {

    public Sprite hat1, hat2, hat3, hat4;


    void Start()
    {
        if (PlayerPrefs.GetInt("buyClothes") == 1)
            if (PlayerPrefs.GetInt("BuySave31") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = hat1;
            }

        if (PlayerPrefs.GetInt("buyClothes") == 2)
            if (PlayerPrefs.GetInt("BuySave32") == 1)
                GetComponent<SpriteRenderer>().sprite = hat2;

        if (PlayerPrefs.GetInt("buyClothes") == 3)
            if (PlayerPrefs.GetInt("BuySave33") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = hat3;
            }
        if (PlayerPrefs.GetInt("buyClothes") == 4)
            if (PlayerPrefs.GetInt("BuySave34") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = hat4;
            }
        
    }
}
