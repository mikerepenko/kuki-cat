using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour {

    public AudioClip soundCar1;
    public AudioClip soundCar2;
    public AudioClip soundCar3;

    void Start () {
        if (PlayerPrefs.GetInt("buyCar") == 2)
            if (PlayerPrefs.GetInt("BuySave12") == 1)
                GetComponent<AudioSource>().clip = soundCar2;
            else
                GetComponent<AudioSource>().clip = soundCar1;

        if (PlayerPrefs.GetInt("buyCar") == 3)
            if (PlayerPrefs.GetInt("BuySave13") == 1)
                GetComponent<AudioSource>().clip = soundCar3;
            else
                GetComponent<AudioSource>().clip = soundCar1;

        if (PlayerPrefs.GetInt("buyCar") == 1)
            GetComponent<AudioSource>().clip = soundCar1;
    }
}
