using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{   
    public GameObject[] animalPrefebs;
    public Transform spawnPosition;

    public float spawnRangeX = 10f;
    public float spawnInterfal = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", 0f, spawnInterfal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawner()
    {
        int randomIndex = Random.Range(0,animalPrefebs.Length);
        GameObject animalToSpawn = animalPrefebs[randomIndex];

        Vector3 spawnAnimal = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),spawnPosition.position.y,spawnPosition.position.z);
        Instantiate(animalToSpawn, spawnAnimal, Quaternion.identity);
    }
}
