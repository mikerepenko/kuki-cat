using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour {

    public float speed;
	
	void Update () {
        if (PlayerPrefs.GetInt("isAnim") != 1)
        {
            if (gameObject.transform.position.x != 6.85f)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(6.85f, transform.position.y, transform.position.z), speed * Time.deltaTime);
        }
        else
            transform.position = new Vector3(15f, transform.position.y, transform.position.z);
    }
}
