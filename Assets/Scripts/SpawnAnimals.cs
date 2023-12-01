using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] animals;
    private int index_animals;
    private Vector3 random_position;
    void Start()
    {
        InvokeRepeating("Spawn",5,1);
    }

    void Spawn ()
    {
        index_animals = Random.Range(0,animals.Length);
        random_position = new Vector3(Random.Range(-15,15),0,25);
        Instantiate(animals[index_animals],random_position,transform.rotation);
    }
    void Update()
    {
        
    }
}
