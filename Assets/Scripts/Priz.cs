using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priz : MonoBehaviour
{

    public float speed;
    private float timer;

    void Start()
    {
        if (PlayerPrefs.GetInt("PrizP") / 1 != 0)
        {
            gameObject.SetActive(false);
            
        }
		PlayerPrefs.SetInt("PrizP", PlayerPrefs.GetInt("PrizP") + 1);
		if (PlayerPrefs.GetInt("PrizP") >= 3)
			PlayerPrefs.SetInt("PrizP", 0);

        

        if (PlayerPrefs.GetInt("BuySave13") == 1)
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("PrizP", 0);
        }
    }

    void Update()
    {
        if (transform.position.y != 3.5f)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0.55f, transform.position.z), speed * 0.02f);
        
    }
    public void YesClick()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
    }
}