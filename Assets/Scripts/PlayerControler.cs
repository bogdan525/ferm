using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour 
{
    private int speed = 10;
    private float horizontalInput;
    private float verticalInput;
    private int zRange = 8;
    private int xRange = 15;
    public GameObject cookie;
    public GameObject steack;
    private GameManager GM;

    void Start()
    {
    GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    

    }
     void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "animal")
        {
            
            Destroy(other.gameObject);
            
            GM.health -= 1;
            GM.HP.text = GM.health + "/3 ";
            if (GM.health == 0)
            {
                 GM.gameOverText.gameObject.SetActive(true);
            GM.rastartBatton.gameObject.SetActive(true);
            Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*speed*horizontalInput);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);
        if (transform.position.x>xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        if (transform.position.x<-xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }
         if (transform.position.z<-zRange)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,-zRange);
        }
         if (transform.position.z>zRange)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,zRange);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cookie,transform.position,cookie.transform.rotation);
        }
         if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(steack,transform.position,steack.transform.rotation);
        }
       
    }
}
