using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject m_on, m_off;
    public Sprite layer_up, layer_down;
    public GameObject ReplayScreen;
    public GameObject AudioGame;
    public GameObject Loading;
    public GameObject Audio;
    public GameObject shop;
    private bool isQuetion;
    public GameObject quetion;
    public GameObject buyGame;
    private bool isMP;
    public GameManager GameManager;
    public GameObject pauseWin;
    public ReplayAnimation ra;
	public GameObject buyKuki;

    void Start()
    {
            PlayerPrefs.SetInt("isAnim", 0);
            isQuetion = true;
            isMP = true;         
            //Проверка звука
            if (gameObject.name == "Music")
            {
            if (PlayerPrefs.GetString("Music") == "no")
            {   
                m_on.SetActive(false);
                m_off.SetActive(true);         
            }
            else
            {
                m_on.SetActive(true);
                m_off.SetActive(false);                
            }
        }
    }
    void OnMouseDown ()
    {
        GetComponent<SpriteRenderer>().sprite = layer_down;
    }
    void OnMouseUp ()
    {
        GetComponent<SpriteRenderer>().sprite = layer_up;
    }
    void Update()
    {
        //Рестарт анимаций кнопок
        //if (PlayerPrefs.GetInt("isAnim") == 1)        
            //transform.position = new Vector3(15f, transform.position.y, transform.position.z);
    }
	public void MusicClick()
	{
		if (PlayerPrefs.GetString("Music") != "no")
			GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
	}
	public void DonateClick()
	{
		if (PlayerPrefs.GetString("Music") != "no")
			GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
		Application.LoadLevel ("donate");
	}
    public void BuyGp()
    {
        //Ссылка на игру
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.mmko.kukicat");


    }

    public void ReviewsClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.mmko.kukicatfree");
    }

    public void MagazinClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        Application.LoadLevel("shop");
    }
    public void PauseButton()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        //Установка параметра паузы
        if (PlayerPrefs.GetInt("Stop") == 0)
        {
            ra.StopReplay();
            GameManager.StartScore();
            Audio.GetComponent<AudioSource>().mute = false;
            PlayerPrefs.SetInt("Stop", 1);
            Time.timeScale = 1;
            //ReplayScreen.SetActive(false);
            //Выкл звука бонусов
            if (PlayerPrefs.GetString("Music") != "no")
                GameObject.Find("BallSound").GetComponent<AudioSource>().mute = false;
            if (PlayerPrefs.GetString("Music") != "no")
                GameObject.Find("Subaru").GetComponent<AudioSource>().mute = false;
            pauseWin.SetActive(false);
        }
        else
        {
            GameManager.StopScore();
            Time.timeScale = 0;
            ra.StartReplay();
            //Установка параметра паузы
            if (PlayerPrefs.GetString("Music") != "no")
                GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
            Audio.GetComponent<AudioSource>().mute = true;
            PlayerPrefs.SetInt("Stop", 0);
            //ReplayScreen.SetActive(true);
            //Выкл звуков бонусов
            if (PlayerPrefs.GetString("Music") != "no")
                GameObject.Find("BallSound").GetComponent<AudioSource>().mute = true;
            if (PlayerPrefs.GetString("Music") != "no")
                GameObject.Find("Subaru").GetComponent<AudioSource>().mute = true;
            pauseWin.SetActive(true);
        }
    }

    public void AdsClick()
    {
         if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
    }

    public void PlayClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
		//Счетчик кол-ва заходов
		//PlayerPrefs.SetInt ("CountEnter", PlayerPrefs.GetInt ("CountEnter") + 1);
        //Установка параметра времени
        Time.timeScale = 1;
		//Проверка на покупку игры
		//if (PlayerPrefs.GetInt ("BuyKuki") == 1 || PlayerPrefs.GetInt("CountEnter") <= 4 || PlayerPrefs.GetInt("NewGamer") != 1)
		//if (PlayerPrefs.GetInt ("BuyKuki") == 1)
			Application.LoadLevel ("loading");
		//else
			//buyKuki.SetActive (true);
    }

    public void MoneyClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        if (isMP)
        {
            buyGame.SetActive(true);
            isMP = false;
        }
        else
        {
            buyGame.SetActive(false);
            isMP = true;
        }
    }

    public void ShopClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        shop.SetActive(true);
        quetion.SetActive(false);
        PlayerPrefs.SetInt("isAnim", 1);
        PlayerPrefs.SetInt("isButtons", 1);
    }

    public void QuesionClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        if (isQuetion)
        {
            quetion.SetActive(true);
            isQuetion = false;
        }
        else
        {
            quetion.SetActive(false);
            isQuetion = true;
        }
    }

    public void ReplayClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        //Установка параметра времени
        Time.timeScale = 1;
        Application.LoadLevel("play");
    }

    public void Replay2Click()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        //Установка параметра времени
        Time.timeScale = 1;
        Application.LoadLevel("play2");
    }

    public void Replay3Click()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        //Установка параметра времени
        Time.timeScale = 1;
        Application.LoadLevel("play3");
    }

    public void HomeClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        Application.LoadLevel("loading2");
    }

    void OnMouseUpAsButton()
    {    
        switch (gameObject.name) 
        {
            case "ShopPlay":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
                Application.LoadLevel("shop");
                break;

            case "BuyGame":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
                break;
            
            case "Music":
                if (PlayerPrefs.GetString("Music") != "no")
                {
                    PlayerPrefs.SetString("Music", "no");
                    m_on.SetActive(false);
                    m_off.SetActive(true);                    
                    AudioGame.SetActive(false);
                }
                else
                {                    
                    PlayerPrefs.SetString("Music", "yes");                  
                    m_on.SetActive(true);
                    m_off.SetActive(false);                    
                    AudioGame.SetActive(true);
                    if (PlayerPrefs.GetString("Music") != "no")
                        GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
                }
                    break;
        }
    }
}
