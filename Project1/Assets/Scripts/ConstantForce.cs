using UnityEngine;

public class ConstantForce : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 forceDirection = new Vector3(0, 0, 1);
    public float forceMagnitude = 5.0f;

    void FixedUpdate()
    {
        rb.AddForce(forceDirection.normalized * forceMagnitude);
    }
}
