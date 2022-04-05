using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopControl : MonoBehaviour {

    public int isPosition = 1;

	public void MapScroll()
    {
        transform.position = new Vector3(14f, 0f, transform.position.z);
        isPosition = 1;
    }
    public void CarScroll()
    {
        transform.position = new Vector3(-3.84f, 0f, transform.position.z);
        isPosition = 2;
    }

    public void PlaneScroll()
    {
        transform.position = new Vector3(-21.69f, 0f, transform.position.z);
        isPosition = 3;
    }

    public void ClothesScroll()
    {
        transform.position = new Vector3(-40.3f, 0f, transform.position.z);
        isPosition = 4;
    }
}
