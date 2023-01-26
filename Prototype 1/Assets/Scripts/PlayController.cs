using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayController : MonoBehaviour
{
    // Enumerations of players' control approaches 
    public enum ControlApproach
    {
        NULL,
        WASD,
        Arrows
    };

    // Control approach of the player
    public ControlApproach controlApproach;

    // Cameras
    public Camera mainCamera;
    public Camera perspectiveCamera;

    // Current player
    private int playerId;

    // Speeds
    private float speed = 15.0f;
    private float turnSpeed = 30.0f;

    // Input settings
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        // camera settings
        mainCamera.enabled = true;
        perspectiveCamera.enabled = false;
        // control approach settings
        if (controlApproach.Equals(ControlApproach.WASD)) playerId = 1;
        else if (controlApproach.Equals(ControlApproach.Arrows)) playerId = 2;
    }

    // Update is called once per frame
    void Update()
    {
        // Get input settings from the input manager
        horizontalInput = Input.GetAxis("Horizontal " + playerId);
        verticalInput = Input.GetAxis("Vertical " + playerId);
        // Conduct operations according to the player ID
        Move();
        // Toggle view if the player presses the corresponding button
        if (playerId.Equals(1))
        {
            if (Input.GetKeyDown(KeyCode.T)) ToggleView();
        }
        else if (playerId.Equals(2))
        {
            if (Input.GetKeyDown(KeyCode.P)) ToggleView();
        }
    }

    // Move the player forward and left/right
    void Move()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * verticalInput));
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

    // Toggle the player's view
    void ToggleView()
    {
        mainCamera.enabled = !mainCamera.enabled;
        perspectiveCamera.enabled = !perspectiveCamera.enabled;
    }
}