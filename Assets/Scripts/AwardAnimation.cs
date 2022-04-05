using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwardAnimation : MonoBehaviour {

    public float speed;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer < 5)
        {
            if (gameObject.transform.position.y != 3.5f)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 3.5f, transform.position.z), speed * 0.02f);
        }
        else
        {
            if (gameObject.transform.position.y != 8f)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 8f, transform.position.z), speed * 0.02f);
        }
    }
}
