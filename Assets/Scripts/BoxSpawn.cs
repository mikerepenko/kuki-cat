using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn : MonoBehaviour {

    public GameObject box;
    public GameObject lamp;
    public GameObject banka;
    public GameObject sliwki;

    private GameObject visibleObject;
    public float timer;
    private int rund;

    void Start()
    {
        timer = 2;
    }

    void FixedUpdate () {
            timer += Time.deltaTime;
            rund = Random.Range(1, 5);
            transform.position = new Vector3(9.96f, transform.position.y, transform.position.z);
            switch (rund)
            {
                case 1:
                    if (visibleObject == null && timer >= 2f)                        
                        visibleObject = Instantiate(box, transform.position, transform.rotation);
                    break;
                case 2:
                    if (visibleObject == null && timer >= 2f)
                        visibleObject = Instantiate(lamp, transform.position, transform.rotation);
                    break;
                case 3:
                    if (visibleObject == null && timer >= 2f)
                        visibleObject = Instantiate(banka, transform.position, transform.rotation);
                    break;
                case 4:
                    if (visibleObject == null && timer >= 2f)
                        visibleObject = Instantiate(sliwki, transform.position, transform.rotation);
                    break;                
        }
        if (timer >= 2f)
            timer = 0;
    }

    public void StopObstracle()
    {
        Destroy(visibleObject);
    }
}

