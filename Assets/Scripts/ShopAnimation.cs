using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopAnimation : MonoBehaviour {

    public float speed;
    public bool isButtons;
    public GameObject ps,clothess,cars,ms,b;

    void Start()
    {


    }

    public void StartButtons()
    {
        isButtons = true;
    }

    public void StopButtons()
    {
        isButtons = false;
    }
   
    void Update()
    {
        if (isButtons)
        {
                if (gameObject.transform.position.y != -5f)
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, -5f, transform.position.z), speed * 0.02f);
                if (b.transform.position.y != -5f)
                    b.transform.position = Vector3.MoveTowards(b.transform.position, new Vector3(b.transform.position.x, -5f, b.transform.position.z), speed * 0.02f);
            
                if (cars.transform.position.x != 7.3f)
                    cars.transform.position = Vector3.MoveTowards(cars.transform.position, new Vector3(7.3f, cars.transform.position.y, cars.transform.position.z), speed * 0.02f);
                if (gameObject.transform.position.x != 7.3f)
                    ms.transform.position = Vector3.MoveTowards(ms.transform.position, new Vector3(7.3f, ms.transform.position.y, ms.transform.position.z), speed * 0.02f);

                if (clothess.transform.position.x != 5.1f)
                    clothess.transform.position = Vector3.MoveTowards(clothess.transform.position, new Vector3(5.1f, clothess.transform.position.y, clothess.transform.position.z), speed * 0.02f);
                if (ps.transform.position.x != 5.1f)
                    ps.transform.position = Vector3.MoveTowards(ps.transform.position, new Vector3(5.1f, ps.transform.position.y, ps.transform.position.z), speed * 0.02f);
        }
        else
        {
                transform.position = new Vector3(transform.position.x, -10f, transform.position.z);
                b.transform.position = new Vector3(b.transform.position.x, -10f, b.transform.position.z);

                cars.transform.position = new Vector3(16f, cars.transform.position.y, cars.transform.position.z);
                ms.transform.position = new Vector3(16f, ms.transform.position.y, ms.transform.position.z);

                clothess.transform.position = new Vector3(14f, clothess.transform.position.y, clothess.transform.position.z);
                ps.transform.position = new Vector3(14f, ps.transform.position.y, ps.transform.position.z);
        }

    }
}
