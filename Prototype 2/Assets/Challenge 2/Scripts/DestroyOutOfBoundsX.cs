using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -40.0f;
    private float bottomLimit = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit or y position is less than bottomLimit
        if (transform.position.x < leftLimit || transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}