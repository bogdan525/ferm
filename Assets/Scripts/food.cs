using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    [Range(0,50)] public int speed; 
    
    void Start()
    {
       
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
        


    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
    }

}
