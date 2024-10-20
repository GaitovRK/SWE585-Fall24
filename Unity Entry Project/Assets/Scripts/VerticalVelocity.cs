using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalVelocity : MonoBehaviour
{

    public float velocity = 10f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb != null) {
            rb.velocity = new Vector3(0, velocity, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
