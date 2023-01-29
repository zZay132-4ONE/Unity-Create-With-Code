using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private Vector3 newPosition = new Vector3(3.0f, 3.0f, 3.0f);
    
    private float changeColorDelay = 0.0f;
    private float changeColorInterval = 2.0f;
    
    private float minScaleChange = 0.99005f;
    private float maxScaleChange = 1.01005f;
    
    private float rotateAngleX = 15.0f;
    private float rotateAngleY = 15.0f;
    private float rotateAngleZ = 15.0f;

    void Start()
    {
        // Change the cube's position
        transform.position = newPosition;
        // Randomly change the cube's color and opacity
        InvokeRepeating("ChangeColor", changeColorDelay, changeColorInterval);
    }

    void Update()
    {
        // Randomly change the cube's scale
        transform.localScale *= Random.Range(minScaleChange, maxScaleChange);
        // Rotate the cube
        transform.Rotate(rotateAngleX * Time.deltaTime, rotateAngleY * Time.deltaTime, rotateAngleZ * Time.deltaTime);
    }

    // Randomly change the cube's color and opacity
    void ChangeColor()
    {
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 0.5f));
    }
}