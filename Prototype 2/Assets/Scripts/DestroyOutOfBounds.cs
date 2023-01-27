using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowBound = -20.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy the game object if it is out of bounds
        if (transform.position.z > topBound || transform.position.z < lowBound)
        {
            if (transform.position.z < lowBound) Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}