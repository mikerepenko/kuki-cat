using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdsHelp : MonoBehaviour {

    private float isChange;
    Image tap;


    void Start()
    {
        tap = GetComponent<Image>();
    }

    void Update()
    {
        isChange += 0.02f;
        if (isChange <= 0.5f)
        {
            tap.color = new Color(255, 255, 255);
        }
        else
        {
            tap.color = new Color(0, 0, 0);
        }
        if (isChange >= 1f)
            isChange = 0;
    }
}
