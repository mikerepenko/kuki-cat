using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private bool isGet;
    public GameObject tap;

    void Awake()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("Stop", 1);

        if (PlayerPrefs.GetInt("FirstGame") != 1)
        {
            PlayerPrefs.SetInt("BuySave1", 1);
            PlayerPrefs.SetInt("Money", 0);
            PlayerPrefs.SetInt("buyIcon", 1);
            PlayerPrefs.SetInt("buyCar", 1);
            PlayerPrefs.SetInt("buyPlane", 1);
            PlayerPrefs.SetInt("buyClothes", 0);
            PlayerPrefs.SetInt("BuySave11", 1);

			PlayerPrefs.SetInt ("NewGamer", 1);
        }
    }
    void Start()
    {
        Application.targetFrameRate = 30;
		//PlayerPrefs.SetInt ("BuyKuki", 0);

        PlayerPrefs.SetInt("isAnim", 0);
        PlayerPrefs.SetInt("isButtons", 0); 
    }
}
