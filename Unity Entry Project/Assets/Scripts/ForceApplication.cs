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
        upplyForce();
        
    }

    void upplyForce() {
        rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
    }
}
