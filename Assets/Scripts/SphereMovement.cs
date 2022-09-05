using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 sphereAcceleration = Input.acceleration;
        sphereAcceleration = Quaternion.Euler(90, 0, 0) * sphereAcceleration;
        rb.AddForce(sphereAcceleration * speed);
    }
}
