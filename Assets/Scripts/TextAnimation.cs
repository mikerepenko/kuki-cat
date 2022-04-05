using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour {

    private float isChange;
    Text tap;
    

	void Start () {
        tap = GetComponent<Text>();
	}
	
	void Update () {
        isChange += 0.02f;
        if (isChange <= 0.5f)
        {
            tap.color = new Color(255,255,255);
        }
        else
        {
            tap.color = new Color(0,0,0);
        }
        if (isChange >= 1f)
            isChange = 0;		
	}
}
