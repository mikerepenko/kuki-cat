using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityDay : MonoBehaviour {

    public float speedBack;

	void Update () {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-19.50f, transform.position.y, transform.position.z), speedBack * Time.deltaTime);
            if (gameObject.transform.position.x < -19.45f)
                transform.position = new Vector3(21.10f, transform.position.y, transform.position.z);
    }
}
