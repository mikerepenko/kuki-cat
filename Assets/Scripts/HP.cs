using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour {

    public Sprite hp1, hp2, hp3, hp4, hp5, hpInfinity;
    private int hp;

    void Start()
    {
        if (PlayerPrefs.GetInt("buyCar") == 2)
            if (PlayerPrefs.GetInt("BuySave12") == 1)
            {
                GetComponent<Image>().sprite = hp3;
                hp = 3;
            }
            else
            {
                GetComponent<Image>().sprite = hp2;
                hp = 2;
            }

        if (PlayerPrefs.GetInt("buyCar") == 3)
            if (PlayerPrefs.GetInt("BuySave13") == 1)
            {
                GetComponent<Image>().sprite = hp4;
                hp = 4;
            }
            else
            {
                GetComponent<Image>().sprite = hp2;
                hp = 2;
            }

        if (PlayerPrefs.GetInt("buyCar") == 4)
            if (PlayerPrefs.GetInt("BuySave14") == 1)
            {
                GetComponent<Image>().sprite = hp5;
                hp = 5;
            }
            else
            {
                GetComponent<Image>().sprite = hp2;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 5)
            if (PlayerPrefs.GetInt("BuySave15") == 1)
            {
                GetComponent<Image>().sprite = hp5;
                hp = 5;
            }
            else
            {
                GetComponent<Image>().sprite = hp2;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 6)
            if (PlayerPrefs.GetInt("BuySave16") == 1)
            {
                GetComponent<Image>().sprite = hpInfinity;
                hp = 100;
            }
            else
            {
                GetComponent<Image>().sprite = hp2;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 7)
            if (PlayerPrefs.GetInt("BuySave17") == 1)
            {
                GetComponent<Image>().sprite = hpInfinity;
                hp = 100;
            }
            else
            {
                GetComponent<Image>().sprite = hp2;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 8)
            if (PlayerPrefs.GetInt("BuySave18") == 1)
            {
                GetComponent<Image>().sprite = hpInfinity;
                hp = 100;
            }
            else
            {
                GetComponent<Image>().sprite = hp2;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 9)
            if (PlayerPrefs.GetInt("BuySave19") == 1)
            {
                GetComponent<Image>().sprite = hp5;
                hp = 5;
            }
            else
            {
                GetComponent<Image>().sprite = hp2;
                hp = 2;
            }
        if (PlayerPrefs.GetInt("buyCar") == 1)
        {
            GetComponent<Image>().sprite = hp2;
            hp = 2;
        }
    }

    public void StartHp()
    {
        if (hp == 2)
            GetComponent<Image>().sprite = hp2;
        if (hp == 3)
            GetComponent<Image>().sprite = hp3;
        if (hp == 4)
            GetComponent<Image>().sprite = hp4;
        if (hp == 5)
            GetComponent<Image>().sprite = hp5;
        if (hp == 100)
            GetComponent<Image>().sprite = hpInfinity;

        GetComponent<Image>().enabled = true;
    }

    public void StopHp()
    {
        GetComponent<Image>().enabled = false;
    }

    public void OneHp()
    {
        GetComponent<Image>().sprite = hp1;
    }

    public void TwoHp()
    {
        GetComponent<Image>().sprite = hp2;
    }   

    public void ThreeHp()
    {
        GetComponent<Image>().sprite = hp3;
    }

    public void FourHp()
    {
        GetComponent<Image>().sprite = hp4;
    }
    
    public void FiveHp()
    {
        GetComponent<Image>().sprite = hp5;
    } 

    public void ManyHp()
    {
        GetComponent<Image>().sprite = hpInfinity;
    }
    
}
