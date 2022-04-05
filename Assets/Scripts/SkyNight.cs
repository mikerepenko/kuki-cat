using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyNight : MonoBehaviour {

    public float speedBack;

	void Update () {
            transform.Translate(-speedBack * Time.deltaTime, 0, 0);
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(-19.50f, transform.position.y, transform.position.z), speedBack * Time.deltaTime);     
            if (gameObject.transform.position.x < -17.33008f)
                transform.position = new Vector3(17.8f, transform.position.y, transform.position.z);
    }
}
