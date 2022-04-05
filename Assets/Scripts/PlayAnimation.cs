using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour {

    public float speed;

	void Update () {
        if (PlayerPrefs.GetInt("isAnim") != 1)
        {
            if (gameObject.transform.position.x != 0f)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, transform.position.y, transform.position.z), speed * Time.deltaTime);
        }
        else
            transform.position = new Vector3(15f, transform.position.y, transform.position.z);
    }
}
