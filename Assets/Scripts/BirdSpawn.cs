using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawn : MonoBehaviour {

    private GameObject visiblebird;
    public float timer = 0;
    public GameObject bird;



    void FixedUpdate()
    {
        timer += Time.deltaTime;
        //Спавн птицы
        if (visiblebird == null && timer >= 2)
        {
            transform.position = new Vector3(50f, 0.43f, transform.position.z);
            visiblebird = Instantiate(bird, transform.position, transform.rotation);
        }
        if (timer >= 2)
            timer = 0;
    }
}
