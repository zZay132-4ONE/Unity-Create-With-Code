using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool canShoot = true;
    private float shootInterval = 1.0f;
    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (canShoot && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canShoot = false;
            Invoke("EnableShoot", shootInterval);
        }
    }
    
    // Enable the player to shoot
    void EnableShoot()
    {
        canShoot = true;
    }
}
