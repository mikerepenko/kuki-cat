using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollClone : MonoBehaviour {

    public float speedObstracles;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-9.96f, transform.position.y, transform.position.z), speedObstracles * Time.deltaTime);
        if (gameObject.transform.position.x < -9.90f)
            Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "cat")
        {
            Destroy(gameObject);
        }
    }
}
