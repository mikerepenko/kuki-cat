using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour {

    private int isLock;
    
    void Start ()
    {
        if (gameObject.name == "Lock")
            isLock = 1;
        if (gameObject.name == "Lock3")
            isLock = 30;
        if (gameObject.name == "Lock12")
            isLock = 2;
        if (gameObject.name == "Lock13")
            isLock = 3;
        if (gameObject.name == "Lock14")
            isLock = 4;
        if (gameObject.name == "Lock15")
            isLock = 5;
        if (gameObject.name == "Lock16")
            isLock = 6;
        if (gameObject.name == "Lock17")
            isLock = 7;
        if (gameObject.name == "Lock18")
            isLock = 8;
        if (gameObject.name == "Lock19")
            isLock = 9;
        if (gameObject.name == "Lock21")
            isLock = 21;
        if (gameObject.name == "Lock22")
            isLock = 22;
        if (gameObject.name == "Lock23")
            isLock = 23;
        if (gameObject.name == "Lock24")
            isLock = 24;
        if (gameObject.name == "Lock31")
            isLock = 31;
        if (gameObject.name == "Lock32")
            isLock = 32;
        if (gameObject.name == "Lock33")
            isLock = 33;
        if (gameObject.name == "Lock34")
            isLock = 34;
    } 

	void Update () {
        if (isLock == 1)
            if (PlayerPrefs.GetInt("BuySave2") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 30)
            if (PlayerPrefs.GetInt("BuySave3") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 2)
            if (PlayerPrefs.GetInt("BuySave12") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 3)
            if (PlayerPrefs.GetInt("BuySave13") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 4)
            if (PlayerPrefs.GetInt("BuySave14") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 5)
            if (PlayerPrefs.GetInt("BuySave15") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 6)
            if (PlayerPrefs.GetInt("BuySave16") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 7)
            if (PlayerPrefs.GetInt("BuySave17") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 8)
            if (PlayerPrefs.GetInt("BuySave18") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 9)
            if (PlayerPrefs.GetInt("BuySave19") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 21)
            if (PlayerPrefs.GetInt("BuySave21") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 22)
            if (PlayerPrefs.GetInt("BuySave22") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 23)
            if (PlayerPrefs.GetInt("BuySave23") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 24)
            if (PlayerPrefs.GetInt("BuySave24") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 31)
            if (PlayerPrefs.GetInt("BuySave31") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 32)
            if (PlayerPrefs.GetInt("BuySave32") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 33)
            if (PlayerPrefs.GetInt("BuySave33") == 1)
            {
                gameObject.SetActive(false);
            }
        if (isLock == 34)
            if (PlayerPrefs.GetInt("BuySave34") == 1)
            {
                gameObject.SetActive(false);
            }
    }
}
