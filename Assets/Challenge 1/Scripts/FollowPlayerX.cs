using System.Collections;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset = new Vector3(30, 0, 10);
    public float smoothSpeed = 5.0f;

    void LateUpdate()
    {
        // Desired position is behind the plane, based on its rotation
        Vector3 desiredPosition = plane.transform.position + plane.transform.TransformDirection(offset);

        // Smoothly interpolate camera position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        // Look at the plane
        transform.LookAt(plane.transform.position);
    }
}
