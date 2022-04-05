using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Cats : MonoBehaviour
{
    public GameObject Replay;
    Rigidbody2D body;
    public AudioSource soundCar;
    private bool isAdd;
    private bool isAddPlane;
    public float jump = 2f;
    public bool isJump;
    public GameObject Record,CatMusic, Audio;
    private int Money = 1;
    private bool isMilk;
    public int MilkCount = 0;
    public GameObject milkSound;
    public GameObject ballMilk;
    public GameObject tap;
    bool isTap;
    Animator cat;
    public GameObject gameOver;
    public Cars Cars;
    public AudioSource coins;
    public GameManager GameManager;
    public ReplayAnimation ra;
    public PlaneControl PlaneControl;
    public Timer timer;

    [SerializeField]
    private GameObject continueAds;
    [SerializeField]
    private bool isOne;

    void Start()
    {
        if (PlayerPrefs.GetInt("FirstStart") == 1)
        {
                //PlayerPrefs.SetInt("Stop",0);
                Time.timeScale = 0;
                isTap = true;
                tap.SetActive(true);        
        }

        cat = gameObject.GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        isMilk = false;
        isAdd = false;
        isAddPlane = false;     
    }
    public void Continue()
    {
        GameManager.StartCallBack();
        Time.timeScale = 1;
        continueAds.SetActive(false);
        body.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
    }
    public void Gameover()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            CatMusic.GetComponent<AudioSource>().Play();
        Time.timeScale = 0;

        Replay.SetActive(true);
        GameObject.Find("Pause").SetActive(false);
        Record.SetActive(true);
        Audio.SetActive(false);
        GameManager.StopScore();
        //Выкл эффектов бонусов
        if (PlayerPrefs.GetString("Music") != "no")
            gameOver.SetActive(true);
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("Subaru").SetActive(false);
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("BallSound").SetActive(false);

        PlayerPrefs.SetInt("Stop", 0);
        PlayerPrefs.SetInt("FirstStart", 0);
        ra.StartReplay();

        continueAds.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "tube" && !isOne)
        {
            if (PlayerPrefs.GetString("Music") != "no")
                CatMusic.GetComponent<AudioSource>().Play();
            continueAds.SetActive(true);
            Time.timeScale = 0;
            isOne = true;
        }
        else if (col.gameObject.tag == "tube" && isOne)
        {
            if (PlayerPrefs.GetString("Music") != "no")
                CatMusic.GetComponent<AudioSource>().Play();
            Time.timeScale = 0;

            Replay.SetActive(true);
            GameObject.Find("Pause").SetActive(false);
            Record.SetActive(true);
            Audio.SetActive(false);
            GameManager.StopScore();
            //Выкл эффектов бонусов
            if (PlayerPrefs.GetString("Music") != "no")
                gameOver.SetActive(true);
            if (PlayerPrefs.GetString("Music") != "no")
                GameObject.Find("Subaru").SetActive(false);
            if (PlayerPrefs.GetString("Music") != "no")
                GameObject.Find("BallSound").SetActive(false);

            PlayerPrefs.SetInt("Stop", 0);
            PlayerPrefs.SetInt("FirstStart", 0);
            ra.StartReplay();
        }

        if (col.gameObject.tag == "platf")
        {
            isJump = true;
            cat.enabled = true;
        }
    }

    void OnCollisionExit2D(Collision2D c)
    {
        if(c.gameObject.tag == "platf")
        {
            cat.enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            //Destroy(other.gameObject);
            Cars.CarStart();  
            if (PlayerPrefs.GetString("Music") != "no")
                soundCar.enabled = true;
            PlayerPrefs.SetInt("FirstCar", 1);
        }

        if (other.gameObject.tag == "plane")
        {
            //Destroy(other.gameObject);
            PlaneControl.StartPlane();
        }

        if (other.gameObject.tag == "money")
        {
            if (PlayerPrefs.GetString("Music") != "no")
                coins.Play();
            //Destroy(other.gameObject);
            GameManager.AddMoney(5);                       
        }

        if (other.gameObject.tag == "milk")
        {
            if (PlayerPrefs.GetString("Music") != "no")
                milkSound.GetComponent<AudioSource>().enabled = true;
            //Destroy(other.gameObject);
            isJump = true;
            isMilk = true;            
            body.mass = 4f;
            body.gravityScale = 1;
            ballMilk.SetActive(true);
            MilkStart();           
        }       
    }

    public void MilkStart()
    {
        isMilk = true;
        timer.StartTM();
    }

    public void MilkStop()
    {
        MilkCount = 0;
        body.mass = 1f;
        body.gravityScale = 5;
        ballMilk.SetActive(false);
        isMilk = false;
        if (PlayerPrefs.GetString("Music") != "no")
            milkSound.GetComponent<AudioSource>().enabled = false;
    }

    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }

    void Update()
    {
        //Появление кота
        if (gameObject.transform.position.x <= -4.4f)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-4.4f, transform.position.y, transform.position.z), 6 * Time.deltaTime);
        

        if (Cars.isCar == true)
        {
            transform.position = new Vector3(-14.94f, -3f, transform.position.z);
            body.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
            isAdd = true;
        }
        else if(isAdd)
        {
            transform.position = new Vector3(-4.4f, -2.5f, transform.position.z);
            body.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            isAdd = false;
        }

        if (PlaneControl.isPlane == true)
        {
            transform.position = new Vector3(-14.94f, -2.5f, transform.position.z);
            body.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
            isAddPlane = true;
        }
        else if (isAddPlane)
        {
            transform.position = new Vector3(-4.4f, -2.5f, transform.position.z);
            body.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            isAddPlane = false;
        }

        if (isMilk == true)
        {
            //Отключение звука при вкл у молока
            if (Cars.isCar == true)
                milkSound.GetComponent<AudioSource>().enabled = false;
        }
        if (PlayerPrefs.GetInt("Stop") == 1)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && isJump && !IsPointerOverUIObject())
            {                       
                    body.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
                    if (!isMilk) isJump = false;
                    else isJump = true;
            }
            //Первый клик
            if (isTap)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                    PlayerPrefs.SetInt("Stop", 1);
                    Time.timeScale = 1;
                    tap.SetActive(false);
                    isTap = false;
                    GameManager.StartScore();
                    PlayerPrefs.SetInt("FirstStart", 0);
                }
            }          
        }
    }
}
    
        
        
