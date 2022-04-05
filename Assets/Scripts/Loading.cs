using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
    {
    public float Timer = 0;
    //public GameObject loading1, loading2, loading3;
    void Start ()
    {
        PlayerPrefs.SetInt("FirstStart", 1);
    }

	void Update ()
    {
        //Запуск игровой сцены с учетом времени
        Timer += Time.deltaTime * 2;
        /*if (Timer < 0.2f)
            loading1.SetActive(true);
        else if (Timer < 0.4f)
            loading2.SetActive(true);
        else if (Timer < 0.6f)
            loading3.SetActive(true);
        if (Timer > 0.6f)*/
        if (transform.localScale.x <= 1.43f)
            transform.localScale = new Vector2(Timer, transform.localScale.y);
        if (transform.localScale.x >= 1.43f)            
        {
            if (PlayerPrefs.GetInt("buyIcon") == 1)
                    Application.LoadLevel("play");

            if (PlayerPrefs.GetInt("buyIcon") == 2)
            {
                if (PlayerPrefs.GetInt("BuySave2") == 1)
                    Application.LoadLevel("play2");
                else
                    Application.LoadLevel("play");
            }

            if (PlayerPrefs.GetInt("buyIcon") == 3)
            {
                if (PlayerPrefs.GetInt("BuySave3") == 1)
                    Application.LoadLevel("play3");
                else
                    Application.LoadLevel("play");
            }

        }
	}
}
