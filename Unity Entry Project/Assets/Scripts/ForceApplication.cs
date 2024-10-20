using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceApplication : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move() {
        if (Input.GetKey(KeyCode.W)) {
            rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A)) {
            rb.AddForce(Vector3.left * force, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S)) {
            rb.AddForce(Vector3.back * force, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.D)) {
            rb.AddForce(Vector3.right * force, ForceMode.Impulse);
        }
    }
}
