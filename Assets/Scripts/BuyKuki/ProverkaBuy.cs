using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProverkaBuy : MonoBehaviour {

	void Start () {
		if (PlayerPrefs.GetInt ("BuyKuki") == 1)
		{
			if (gameObject.name == "MoneyFree")
				gameObject.SetActive (false);
		}
		else
			if (gameObject.name == "Money")
				gameObject.SetActive (false);
	}
}
