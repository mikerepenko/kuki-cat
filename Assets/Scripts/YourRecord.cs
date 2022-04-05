using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YourRecord : MonoBehaviour {

    public float speed;
	
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-5.9f, transform.position.y, transform.position.z), speed * 0.02f);
    }
}
