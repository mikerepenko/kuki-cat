using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopBuy : MonoBehaviour
{
    public GameObject buyFailed;
    public Text priceShop;
    public Sprite layer_up, layer_down;
    public ShopControl ShopControl;


    void Start()
    {
        PlayerPrefs.SetInt("isScroll", 1);
        PlayerPrefs.SetInt("isScrollCar", 1);
        PlayerPrefs.SetInt("isScrollPlane", 1);
        PlayerPrefs.SetInt("isScrollClothes", 1);
    }

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = layer_down;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_up;
    }

    

    public void BackClick()
    {
        PlayerPrefs.SetInt("isAnim", 0);
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

        PlayerPrefs.SetInt("isButtons", 0);
        GameObject.Find("ShopPanel").SetActive(false);
        priceShop.text = "";
        buyFailed.SetActive(false);
    }

    public void BuyClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

        buyFailed.SetActive(false);
        if (ShopControl.isPosition == 1)
            if (PlayerPrefs.GetInt("BuySave2") != 1)
                if (PlayerPrefs.GetInt("buyIcon") == 2)
                    if (PlayerPrefs.GetInt("Money") >= 5000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 5000);
                        PlayerPrefs.SetInt("BuySave2", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 1)
            if (PlayerPrefs.GetInt("BuySave3") != 1)
                if (PlayerPrefs.GetInt("buyIcon") == 3)
                    if (PlayerPrefs.GetInt("Money") >= 10000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 10000);
                        PlayerPrefs.SetInt("BuySave3", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);

        if (ShopControl.isPosition == 2)
            if (PlayerPrefs.GetInt("BuySave12") != 1)
                if (PlayerPrefs.GetInt("buyCar") == 2)
                    if (PlayerPrefs.GetInt("Money") >= 5000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 5000);
                        PlayerPrefs.SetInt("BuySave12", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 2)
            if (PlayerPrefs.GetInt("BuySave13") != 1)
                if (PlayerPrefs.GetInt("buyCar") == 3)
                    if (PlayerPrefs.GetInt("Money") >= 10000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 10000);
                        PlayerPrefs.SetInt("BuySave13", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 2)
            if (PlayerPrefs.GetInt("BuySave14") != 1)
                if (PlayerPrefs.GetInt("buyCar") == 4)
                    if (PlayerPrefs.GetInt("Money") >= 15000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 15000);
                        PlayerPrefs.SetInt("BuySave14", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 2)
            if (PlayerPrefs.GetInt("BuySave15") != 1)
                if (PlayerPrefs.GetInt("buyCar") == 5)
                    if (PlayerPrefs.GetInt("Money") >= 20000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 20000);
                        PlayerPrefs.SetInt("BuySave15", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 2)
            if (PlayerPrefs.GetInt("BuySave16") != 1)
                if (PlayerPrefs.GetInt("buyCar") == 6)
                    if (PlayerPrefs.GetInt("Money") >= 25000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 25000);
                        PlayerPrefs.SetInt("BuySave16", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 2)
            if (PlayerPrefs.GetInt("BuySave17") != 1)
                if (PlayerPrefs.GetInt("buyCar") == 7)
                    if (PlayerPrefs.GetInt("Money") >= 30000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 30000);
                        PlayerPrefs.SetInt("BuySave17", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 2)
            if (PlayerPrefs.GetInt("BuySave18") != 1)
                if (PlayerPrefs.GetInt("buyCar") == 8)
                    if (PlayerPrefs.GetInt("Money") >= 35000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 35000);
                        PlayerPrefs.SetInt("BuySave18", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 2)
            if (PlayerPrefs.GetInt("BuySave19") != 1)
                if (PlayerPrefs.GetInt("buyCar") == 9)
                    if (PlayerPrefs.GetInt("Money") >= 50000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 50000);
                        PlayerPrefs.SetInt("BuySave19", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 3)
            if (PlayerPrefs.GetInt("BuySave22") != 1)
                if (PlayerPrefs.GetInt("buyPlane") == 2)
                    if (PlayerPrefs.GetInt("Money") >= 5000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 5000);
                        PlayerPrefs.SetInt("BuySave22", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 3)
            if (PlayerPrefs.GetInt("BuySave23") != 1)
                if (PlayerPrefs.GetInt("buyPlane") == 3)
                    if (PlayerPrefs.GetInt("Money") >= 10000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 10000);
                        PlayerPrefs.SetInt("BuySave23", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 3)
            if (PlayerPrefs.GetInt("BuySave24") != 1)
                if (PlayerPrefs.GetInt("buyPlane") == 4)
                    if (PlayerPrefs.GetInt("Money") >= 15000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 15000);
                        PlayerPrefs.SetInt("BuySave24", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 4)
            if (PlayerPrefs.GetInt("BuySave31") != 1)
                if (PlayerPrefs.GetInt("buyClothes") == 1)
                    if (PlayerPrefs.GetInt("Money") >= 2000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 2000);
                        PlayerPrefs.SetInt("BuySave31", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 4)
            if (PlayerPrefs.GetInt("BuySave32") != 1)
                if (PlayerPrefs.GetInt("buyClothes") == 2)
                    if (PlayerPrefs.GetInt("Money") >= 4000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 4000);
                        PlayerPrefs.SetInt("BuySave32", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 4)
            if (PlayerPrefs.GetInt("BuySave33") != 1)
                if (PlayerPrefs.GetInt("buyClothes") == 3)
                    if (PlayerPrefs.GetInt("Money") >= 6000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 4000);
                        PlayerPrefs.SetInt("BuySave33", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
        if (ShopControl.isPosition == 4)
            if (PlayerPrefs.GetInt("BuySave34") != 1)
                if (PlayerPrefs.GetInt("buyClothes") == 4)
                    if (PlayerPrefs.GetInt("Money") >= 8000)
                    {
                        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 8000);
                        PlayerPrefs.SetInt("BuySave34", 1);
                        GameObject.Find("BuySound").GetComponent<AudioSource>().Play();
                        priceShop.text = "";
                        buyFailed.SetActive(false);
                    }
                    else
                        buyFailed.SetActive(true);
    }

    public void MapClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        priceShop.text = "";
        buyFailed.SetActive(false);
        ShopControl.MapScroll();
    }

    public void CarShopClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        priceShop.text = "";
        buyFailed.SetActive(false);
        ShopControl.CarScroll();
    }

    public void ClothesShopClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        priceShop.text = "";
        buyFailed.SetActive(false);
        ShopControl.ClothesScroll();
    }

    public void PlaneShopClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        priceShop.text = "";
        buyFailed.SetActive(false);
        ShopControl.PlaneScroll();
    }

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Button1":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyIcon", 1);
                if (PlayerPrefs.GetInt("BuySave1") == 1)
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;

            case "Button2":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyIcon", 2);
                if (PlayerPrefs.GetInt("BuySave2") == 0)
                    priceShop.text = "Цена: " + "5000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;
            case "Button3":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyIcon", 3);
                if (PlayerPrefs.GetInt("BuySave3") == 0)
                    priceShop.text = "Цена: " + "10000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;

            case "ButtonCommon":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                priceShop.text = "";
                buyFailed.SetActive(false);
                break;

            case "Button11":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyCar", 1);
                if (PlayerPrefs.GetInt("BuySave11") == 1)
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;

            case "Button12":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyCar", 2);
                if (PlayerPrefs.GetInt("BuySave12") == 0)
                    priceShop.text = "Цена: " + "5000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;

            case "Button13":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyCar", 3);
                if (PlayerPrefs.GetInt("BuySave13") == 0)
                    priceShop.text = "Цена: " + "10000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;

            case "Button14":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyCar", 4);
                if (PlayerPrefs.GetInt("BuySave14") == 0)
                    priceShop.text = "Цена: " + "15000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;
            case "Button15":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyCar", 5);
                if (PlayerPrefs.GetInt("BuySave15") == 0)
                    priceShop.text = "Цена: " + "20000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;
            case "Button16":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyCar", 6);
                if (PlayerPrefs.GetInt("BuySave16") == 0)
                    priceShop.text = "Цена: " + "25000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;
            case "Button17":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyCar", 7);
                if (PlayerPrefs.GetInt("BuySave17") == 0)
                    priceShop.text = "Цена: " + "30000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;
            case "Button18":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyCar", 8);
                if (PlayerPrefs.GetInt("BuySave18") == 0)
                    priceShop.text = "Цена: " + "35000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;
            case "Button19":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyCar", 9);
                if (PlayerPrefs.GetInt("BuySave19") == 0)
                    priceShop.text = "Цена: " + "50000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;

            case "Button21":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyPlane", 1);
                if (PlayerPrefs.GetInt("BuySave21") == 1)
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;

            case "Button22":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyPlane", 2);
                if (PlayerPrefs.GetInt("BuySave22") == 0)
                    priceShop.text = "Цена: " + "5000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;
            case "Button23":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyPlane", 3);
                if (PlayerPrefs.GetInt("BuySave23") == 0)
                    priceShop.text = "Цена: " + "10000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;
            case "Button24":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                PlayerPrefs.SetInt("buyPlane", 4);
                if (PlayerPrefs.GetInt("BuySave24") == 0)
                    priceShop.text = "Цена: " + "15000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;
            case "Button31":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                if (PlayerPrefs.GetInt("buyClothes") != 1)
                    PlayerPrefs.SetInt("buyClothes", 1);
                else
                    PlayerPrefs.SetInt("buyClothes", 0);

                if (PlayerPrefs.GetInt("BuySave31") == 0)
                    priceShop.text = "Цена: " + "2000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;

            case "Button32":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                if (PlayerPrefs.GetInt("buyClothes") != 2)
                    PlayerPrefs.SetInt("buyClothes", 2);
                else
                    PlayerPrefs.SetInt("buyClothes", 0);

                if (PlayerPrefs.GetInt("BuySave32") == 0)
                    priceShop.text = "Цена: " + "4000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;
            case "Button33":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                if (PlayerPrefs.GetInt("buyClothes") != 3)
                    PlayerPrefs.SetInt("buyClothes", 3);
                else
                    PlayerPrefs.SetInt("buyClothes", 0);

                if (PlayerPrefs.GetInt("BuySave33") == 0)
                    priceShop.text = "Цена: " + "6000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;
            case "Button34":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();

                if (PlayerPrefs.GetInt("buyClothes") != 4)
                    PlayerPrefs.SetInt("buyClothes", 4);
                else
                    PlayerPrefs.SetInt("buyClothes", 0);

                if (PlayerPrefs.GetInt("BuySave34") == 0)
                    priceShop.text = "Цена: " + "8000";
                else
                {
                    priceShop.text = "";
                    buyFailed.SetActive(false);
                }
                break;

            case "Next":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
                //Скрол в магазине вперед
                if (PlayerPrefs.GetInt("isScroll") < 4)
                    PlayerPrefs.SetInt("isScroll", PlayerPrefs.GetInt("isScroll") + 1);
                
                priceShop.text = "";
                buyFailed.SetActive(false);
                break;

            case "NextBack":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
                //Скрол в магазине назад
                if (PlayerPrefs.GetInt("isScroll") > 1)
                    PlayerPrefs.SetInt("isScroll", PlayerPrefs.GetInt("isScroll") - 1);
                else
                    PlayerPrefs.SetInt("isScroll", 3);
                priceShop.text = "";
                buyFailed.SetActive(false);
                break;

            case "NextCar":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
                //Скрол в магазине вперед
                if (PlayerPrefs.GetInt("isScrollCar") < 10)
                    PlayerPrefs.SetInt("isScrollCar", PlayerPrefs.GetInt("isScrollCar") + 1);
                priceShop.text = "";
                buyFailed.SetActive(false);
                break;

            case "BackCar":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
                //Скрол в магазине назад
                if (PlayerPrefs.GetInt("isScrollCar") > 1)
                    PlayerPrefs.SetInt("isScrollCar", PlayerPrefs.GetInt("isScrollCar") - 1);
                else
                    PlayerPrefs.SetInt("isScrollCar", 9);
                priceShop.text = "";
                buyFailed.SetActive(false);
                break;

            case "NextPlane":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
                //Скрол в магазине вперед
                if (PlayerPrefs.GetInt("isScrollPlane") < 5)
                    PlayerPrefs.SetInt("isScrollPlane", PlayerPrefs.GetInt("isScrollPlane") + 1);
                priceShop.text = "";
                buyFailed.SetActive(false);
                break;

            case "BackPlane":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
                //Скрол в магазине назад
                if (PlayerPrefs.GetInt("isScrollPlane") > 1)
                    PlayerPrefs.SetInt("isScrollPlane", PlayerPrefs.GetInt("isScrollPlane") - 1);
                else
                    PlayerPrefs.SetInt("isScrollPlane", 5);
                priceShop.text = "";
                buyFailed.SetActive(false);
                break;
            case "NextClothes":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
                //Скрол в магазине вперед
                if (PlayerPrefs.GetInt("isScrollClothes") < 5)
                    PlayerPrefs.SetInt("isScrollClothes", PlayerPrefs.GetInt("isScrollClothes") + 1);
                priceShop.text = "";
                buyFailed.SetActive(false);
                break;

            case "BackClothes":
                if (PlayerPrefs.GetString("Music") != "no")
                    GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
                //Скрол в магазине назад
                if (PlayerPrefs.GetInt("isScrollClothes") > 1)
                    PlayerPrefs.SetInt("isScrollClothes", PlayerPrefs.GetInt("isScrollClothes") - 1);
                else
                    PlayerPrefs.SetInt("isScrollClothes", 4);
                priceShop.text = "";
                buyFailed.SetActive(false);
                break;
        }
    }
}
