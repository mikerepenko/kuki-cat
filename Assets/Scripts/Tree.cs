using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {

    public float speedBack;
    public GameObject tree;	

	void Update () {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-18.30f, transform.position.y, transform.position.z), speedBack * Time.deltaTime);
            if (gameObject.transform.position.x < -18.21f)
                transform.position = new Vector3(19.13f, transform.position.y, transform.position.z);
        tree.transform.position = Vector3.MoveTowards(tree.transform.position, new Vector3(-18.30f, tree.transform.position.y, tree.transform.position.z), speedBack * Time.deltaTime);
        if (tree.transform.position.x < -18.21f)
            tree.transform.position = new Vector3(19.13f, tree.transform.position.y, tree.transform.position.z);
    }
}
