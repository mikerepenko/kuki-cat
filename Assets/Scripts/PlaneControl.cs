using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControl : MonoBehaviour {

    Rigidbody2D plane;
    public float jump;
    private bool isJump;
    public float speedRotate;
    private bool isRotate;
    public Sprite plane1, plane2, plane3, plane4;
    SpriteRenderer planeSprite;
    public GameObject crash;
    private GameObject visibleObject;
    public bool isPlane;
    public AudioSource coins;
    public GameManager GM;
    public AudioSource explotion;
    public AudioSource planeSound;
    public Rocket rocket;
    private int countRocket;
    public float posP;
    public BoxSpawn boxSpawn;


    void Start()
    {
        plane = GetComponent<Rigidbody2D>();
        isJump = true;
        planeSprite = GetComponent<SpriteRenderer>();

        if (PlayerPrefs.GetInt("buyPlane") == 2)
            if (PlayerPrefs.GetInt("BuySave22") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = plane2;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = plane1;
            }

        if (PlayerPrefs.GetInt("buyPlane") == 3)
            if (PlayerPrefs.GetInt("BuySave23") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = plane3;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = plane1;
            }

        if (PlayerPrefs.GetInt("buyPlane") == 4)
            if (PlayerPrefs.GetInt("BuySave24") == 1)
            {
                GetComponent<SpriteRenderer>().sprite = plane4;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = plane1;
            }

        if (PlayerPrefs.GetInt("buyPlane") == 1)
        {
            GetComponent<SpriteRenderer>().sprite = plane1;
        }
    }

    public void StartPlane()
    {
        isPlane = true;
        isJump = true;
        planeSound.enabled = true;
        countRocket = 0;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "money")
        {
            if (PlayerPrefs.GetString("Music") != "no")
                coins.GetComponent<AudioSource>().Play();
            //Destroy(other.gameObject);
            GM.AddMoney(5);
        }
        /*if (other.gameObject.tag == "milk")
            Destroy(other.gameObject);

        if (other.gameObject.tag == "Finish")
            Destroy(other.gameObject);

        if (other.gameObject.tag == "plane")
            Destroy(other.gameObject);*/
        
    }

    public void StopPlane()
    {
        isPlane = false;
        planeSound.enabled = false;
        explotion.Play();
        plane.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        boxSpawn.StopObstracle();        
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        //if (c.gameObject.tag == "roof")
            //isJump = false;
        if (c.gameObject.tag == "platf")
        {
            StopPlane();
            //planeSprite.enabled = false;
            if (visibleObject == null)
                visibleObject = Instantiate(crash, new Vector2(-2.804882f, -2.762676f), transform.rotation);    
            transform.position = new Vector3(-14f, 1f, transform.rotation.z);            
        }
        if (c.gameObject.tag == "tube")
        {
            Destroy(c.gameObject);
            isJump = false;
        }
        if (c.gameObject.tag == "rocket")
        {
            rocket.StopRocket();
            isJump = false;
        }
    }

    void Update ()
    {
        if (isPlane)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-5.15f, transform.position.y, transform.position.z), 5f * Time.deltaTime);

            if (gameObject.transform.position.x >= -6.5f)
                plane.constraints = RigidbodyConstraints2D.FreezePositionX;

            //planeSprite.sprite = planeUp;

            if (gameObject.transform.position.x >= -6.5f)
                transform.Rotate(0, 0, -speedRotate * Time.deltaTime / 0.1f);

            if (Input.GetKeyDown(KeyCode.Mouse0) && isJump)
            {
                countRocket++;
                if (countRocket % 10 == 0)
                {
                    posP = transform.position.y;
                    rocket.PositionRocket(posP);
                }
                if (gameObject.transform.rotation.z <= 0)
                    isRotate = true;
                plane.AddForce(Vector2.up * jump, ForceMode2D.Impulse);

                //if (visibleExhaust == null)
                
                
                //planeSprite.sprite = planeDown;
            }

            if (isRotate)
            {
                if (gameObject.transform.rotation.z <= 0)
                    transform.Rotate(0, 0, speedRotate * Time.deltaTime * 40f);
                else
                    isRotate = false;
            }
        }
        else
        {
            transform.position = new Vector3(-13.65f, 1.7f, transform.position.z);
            transform.rotation = new Quaternion(0, 0, 0, 0);
            //transform.rotation(0, 0, -0.9f);
        }
    }
}
