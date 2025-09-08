using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float spinSpeed = 1000f;

    void Update()
    {
        // Spin the propeller around the z axis
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}
