using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeather : MonoBehaviour {

    public Sprite dayMenu,winterMenu;
    public Sprite daySkyBox;
    public AudioClip daySound,winterSound;
    public Sprite dayPoligon, winterPoligon;
    public AudioClip dayMusic;

	void Start () {
        if (PlayerPrefs.GetInt("buyIcon") == 3)
            {
                if (gameObject.name == "Snow")
                    gameObject.SetActive(false);
            }

        if (PlayerPrefs.GetInt("buyIcon") == 2)
        {
                if (gameObject.name == "SkyMenu1" || gameObject.name == "SkyMenu2")
                    GetComponent<SpriteRenderer>().sprite = dayMenu;
                if (gameObject.name == "SkyShop1" || gameObject.name == "SkyShop2")
                    GetComponent<SpriteRenderer>().sprite = dayMenu;
                if (gameObject.name == "SkyNight1" || gameObject.name == "SkyNight2")
                    GetComponent<SpriteRenderer>().sprite = daySkyBox;
                if (gameObject.name == "Rain")
                    gameObject.SetActive(false);
                if (gameObject.name == "Snow")
                    gameObject.SetActive(false);
                if (gameObject.name == "Thunder")
                {
                    GetComponent<AudioSource>().clip = daySound;
                    GetComponent<AudioSource>().Play();
                }
                if (gameObject.name == "poligon")
                    GetComponent<SpriteRenderer>().sprite = dayPoligon;
                if (gameObject.name == "Audio")
                {
                    GetComponent<AudioSource>().clip = dayMusic;
                    GetComponent<AudioSource>().Play();
                }
            }
        if (PlayerPrefs.GetInt("buyIcon") == 1)
        {
            if (gameObject.name == "SkyMenu1" || gameObject.name == "SkyMenu2")
                //GetComponent<SpriteRenderer>().sprite = winterMenu;
                gameObject.SetActive(false);
            if (gameObject.name == "SkyShop1" || gameObject.name == "SkyShop2")
                //GetComponent<SpriteRenderer>().sprite = winterMenu;
                gameObject.SetActive(false);
            if (gameObject.name == "SkyNight1" || gameObject.name == "SkyNight2")
                //GetComponent<SpriteRenderer>().enabled = false;
                gameObject.SetActive(false);
            if (gameObject.name == "Rain")
                gameObject.SetActive(false);
            if (gameObject.name == "Thunder")
            {
                GetComponent<AudioSource>().clip = winterSound;
                GetComponent<AudioSource>().Play();
            }
            if (gameObject.name == "poligon")
                GetComponent<SpriteRenderer>().sprite = winterPoligon;

        }
    }
}
