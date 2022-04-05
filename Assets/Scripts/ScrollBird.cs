using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBird : MonoBehaviour {

    public float timer;
    private GameObject visibleObject;
    public GameObject bird;

	void FixedUpdate () {
        timer += Time.deltaTime;
        if (visibleObject == null && timer >= 2f)
        {
            transform.position = new Vector3(52f, 0.43f, transform.position.z);
            visibleObject = Instantiate(bird, transform.position, transform.rotation);
        }
        if (timer >= 2)
            timer = 0;
    }
}
