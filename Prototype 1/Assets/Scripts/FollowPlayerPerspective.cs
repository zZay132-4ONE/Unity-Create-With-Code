using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerPerspective : MonoBehaviour
{
    // Player
    public GameObject player;

    // Offset of the camera relative to the player
    private Vector3 offset = new Vector3(0, 4.5f, -0.2f);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
    }
}
