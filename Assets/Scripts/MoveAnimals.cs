using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveAnimals : MonoBehaviour
{
    private float speed = 8;
    private float downRange = -14;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        if (transform.position.z<downRange)
        {
            Destroy(gameObject);
        }
    }
}
