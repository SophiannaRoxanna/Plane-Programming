using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 5.0f;      // Forward speed
    private float pitchSpeed = 20.0f; // Speed at which the plane tilts up/down

    private float verticalInput; // Input for tilt control

    void Update()
    {
        // Get the vertical input (W/S or Up/Down arrows)
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward constantly
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Pitch (tilt the plane up and down)
        // Negative input tilts the plane up and positive input tilts it down
        transform.Rotate(Vector3.right, -verticalInput * pitchSpeed * Time.deltaTime);
    }
}
