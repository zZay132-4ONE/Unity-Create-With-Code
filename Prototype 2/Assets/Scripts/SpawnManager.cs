using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;

    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    // Randomly spawn animals 
    void SpawnRandomAnimal()
    {
        int animalId = Random.Range(0, animalsPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalsPrefabs[animalId], spawnPosition, animalsPrefabs[animalId].transform.rotation);
    }
}