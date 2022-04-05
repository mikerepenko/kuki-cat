using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBk : MonoBehaviour {

	public float speed;

	void Start () {
		//PlayerPrefs.SetInt ("BuyKuki", 0);
		if (PlayerPrefs.GetInt ("BuyKuki") == 1)
			gameObject.SetActive (false);
		
	}

	void Update () {
		if (transform.position.y != 3.5f)
			transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0.55f, transform.position.z), speed * 0.02f);
	}

	public void BackClick()
	{
		if (PlayerPrefs.GetString("Music") != "no")
			GameObject.Find("Click audio").GetComponent<AudioSource>().Play();
		gameObject.SetActive(false);
	}
}
