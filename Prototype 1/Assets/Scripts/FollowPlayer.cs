using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Player
    public GameObject player;

    // Offset of the camera relative to the player
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame (during the frame)
    void Update()
    {
    }

    // LateUpdate is called once per frame (at the end of the frame)
    private void LateUpdate()
    {
        // Follow the player
        transform.position = player.transform.position + offset;
    }
}