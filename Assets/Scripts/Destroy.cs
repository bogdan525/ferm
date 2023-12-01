 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour

{
    private GameManager GM;
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "animal")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GM.UpdateScores(1);
        }
    }
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
