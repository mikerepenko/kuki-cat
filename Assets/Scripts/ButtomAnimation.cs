using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomAnimation : MonoBehaviour {
	
	void Update () {
        if (PlayerPrefs.GetInt("Stop") == 0)
        {
            if (gameObject.transform.position.y != -3f)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -3f, transform.position.z), 10 * 0.02f);
        }
        else
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -5.7f, transform.position.z), 15 * 0.02f);

    }
}
