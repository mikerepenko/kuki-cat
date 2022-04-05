using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObstracles : MonoBehaviour {

    public float speedObstracles;
	
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-9.96f, transform.position.y, transform.position.z), speedObstracles * Time.deltaTime);
        if (gameObject.transform.position.x < -9.90f)
            Destroy(gameObject);
    }
}
