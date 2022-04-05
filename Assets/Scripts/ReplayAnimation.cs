using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayAnimation : MonoBehaviour {

    public float speed;
    public bool isReplay;

    public void StartReplay()
    {
        isReplay = true;
    }

    public void StopReplay()
    {
        isReplay = false;
    }
    void Update()
    {
        if (isReplay)
        {
            if (gameObject.transform.position.x != 1.4f)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0.9f, transform.position.z), speed * 0.02f);
            
        }
        else
            if (gameObject.transform.position.y != 10f)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 10f, transform.position.z), speed * 0.02f);
    }
}
