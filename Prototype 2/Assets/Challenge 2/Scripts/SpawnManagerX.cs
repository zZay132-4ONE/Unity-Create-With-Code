using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnIntervalMin = 3.0f;
    private float spawnIntervalMax = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // instantiate random ball type at random spawn location
        int ballId = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        Instantiate(ballPrefabs[ballId], spawnPosition, ballPrefabs[ballId].transform.rotation);
        // Invoke SpawnRandomBall() recursively
        Invoke("SpawnRandomBall", Random.Range(spawnIntervalMin, spawnIntervalMax));
    }
}