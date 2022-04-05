using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyMenu : MonoBehaviour {

    public float speedBack;
    public GameObject skyMenu;

	void FixedUpdate ()
    {
        transform.Translate(-speedBack * Time.deltaTime,0,0);         
        if (gameObject.transform.position.x < -19.45f)
            transform.position = new Vector3(20.5f, transform.position.y, transform.position.z);
        skyMenu.transform.Translate(-speedBack * Time.deltaTime, 0, 0);
        if (skyMenu.transform.position.x < -19.45f)
            skyMenu.transform.position = new Vector3(20.5f, skyMenu.transform.position.y, skyMenu.transform.position.z);
    }
}
