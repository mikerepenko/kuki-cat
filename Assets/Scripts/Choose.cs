using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choose : MonoBehaviour {

    public Sprite layer_up, layer_down;
    public string name;

    void Start()
    {
        if (gameObject.name == "Choose1")
            name = "Choose1";
        else if (gameObject.name == "Choose2")
            name = "Choose2";
        else if (gameObject.name == "Choose3")
            name = "Choose3";
        else if (gameObject.name == "Choose11")
            name = "Choose11";
        else if (gameObject.name == "Choose12")
            name = "Choose12";
        else if (gameObject.name == "Choose13")
            name = "Choose13";
        else if (gameObject.name == "Choose14")
            name = "Choose14";
        else if (gameObject.name == "Choose15")
            name = "Choose15";
        else if (gameObject.name == "Choose16")
            name = "Choose16";
        else if (gameObject.name == "Choose17")
            name = "Choose17";
        else if (gameObject.name == "Choose18")
            name = "Choose18";
        else if (gameObject.name == "Choose19")
            name = "Choose19";
        if (gameObject.name == "Choose21")
            name = "Choose21";
        else if (gameObject.name == "Choose22")
            name = "Choose22";
        else if (gameObject.name == "Choose23")
            name = "Choose23";
        else if (gameObject.name == "Choose24")
            name = "Choose24";
        if (gameObject.name == "Choose31")
            name = "Choose31";
        else if (gameObject.name == "Choose32")
            name = "Choose32";
        else if (gameObject.name == "Choose33")
            name = "Choose33";
        else if (gameObject.name == "Choose34")
            name = "Choose34";
    }

    void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        switch (gameObject.name)
        {
            case "Choose1":
                PlayerPrefs.SetInt("buyIcon", 1);
                break;
            case "Choose2":
                PlayerPrefs.SetInt("buyIcon", 2);
                break;
            case "Choose3":
                PlayerPrefs.SetInt("buyIcon", 3);
                break;
            case "Choose11":
                PlayerPrefs.SetInt("buyCar", 1);
                break;
            case "Choose12":
                PlayerPrefs.SetInt("buyCar", 2);
                break;
            case "Choose13":
                PlayerPrefs.SetInt("buyCar", 3);
                break;
            case "Choose14":
                PlayerPrefs.SetInt("buyCar", 4);
                break;
            case "Choose15":
                PlayerPrefs.SetInt("buyCar", 5);
                break;
            case "Choose16":
                PlayerPrefs.SetInt("buyCar", 6);
                break;
            case "Choose17":
                PlayerPrefs.SetInt("buyCar", 7);
                break;
            case "Choose18":
                PlayerPrefs.SetInt("buyCar", 8);
                break;
            case "Choose19":
                PlayerPrefs.SetInt("buyCar", 9);
                break;
            case "Choose21":
                PlayerPrefs.SetInt("buyPlane", 1);
                break;
            case "Choose22":
                PlayerPrefs.SetInt("buyPlane", 2);
                break;
            case "Choose23":
                PlayerPrefs.SetInt("buyPlane", 3);
                break;
            case "Choose24":
                PlayerPrefs.SetInt("buyPlane", 4);
                break;
            case "Choose31":
                PlayerPrefs.SetInt("buyClothes", 1);
                break;
            case "Choose32":
                PlayerPrefs.SetInt("buyClothes", 2);
                break;
            case "Choose33":
                PlayerPrefs.SetInt("buyClothes", 3);
                break;
            case "Choose34":
                PlayerPrefs.SetInt("buyClothes", 4);
                break;
        }
    }
    void Update () {
        if (name == "Choose1")
            if(PlayerPrefs.GetInt("buyIcon") == 1)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose2")
                if (PlayerPrefs.GetInt("buyIcon") == 2)
                    GetComponent<SpriteRenderer>().sprite = layer_down;
                else
                    GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose3")
            if (PlayerPrefs.GetInt("buyIcon") == 3)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose11")
            if (PlayerPrefs.GetInt("buyCar") == 1)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose12")
            if (PlayerPrefs.GetInt("buyCar") == 2)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose13")
            if (PlayerPrefs.GetInt("buyCar") == 3)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose14")
            if (PlayerPrefs.GetInt("buyCar") == 4)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose15")
            if (PlayerPrefs.GetInt("buyCar") == 5)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose16")
            if (PlayerPrefs.GetInt("buyCar") == 6)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose17")
            if (PlayerPrefs.GetInt("buyCar") == 7)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose18")
            if (PlayerPrefs.GetInt("buyCar") == 8)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose19")
            if (PlayerPrefs.GetInt("buyCar") == 9)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose21")
            if (PlayerPrefs.GetInt("buyPlane") == 1)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose22")
            if (PlayerPrefs.GetInt("buyPlane") == 2)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose23")
            if (PlayerPrefs.GetInt("buyPlane") == 3)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose24")
            if (PlayerPrefs.GetInt("buyPlane") == 4)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose31")
            if (PlayerPrefs.GetInt("buyClothes") == 1)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose32")
            if (PlayerPrefs.GetInt("buyClothes") == 2)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose33")
            if (PlayerPrefs.GetInt("buyClothes") == 3)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
        if (name == "Choose34")
            if (PlayerPrefs.GetInt("buyClothes") == 4)
                GetComponent<SpriteRenderer>().sprite = layer_down;
            else
                GetComponent<SpriteRenderer>().sprite = layer_up;
    }
}
