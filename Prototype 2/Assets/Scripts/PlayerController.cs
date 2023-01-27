using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;

    private float horizontalInput;
    private float speed = 25.0f;
    private float range = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Move the player and keep the player in bounds
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (speed * horizontalInput * Time.deltaTime));
        if (Mathf.Abs(transform.position.x) > range)
            transform.position = new Vector3((transform.position.x > 0) ? range : -range, transform.position.y, transform.position.z);
        // Launch a projectile from the player
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
}