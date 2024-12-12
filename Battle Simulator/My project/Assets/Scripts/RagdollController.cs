using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{

    private List<Rigidbody> _rigidbodies = new List<Rigidbody>();

    public void Initialize()
    {
        _rigidbodies = new List<Rigidbody>(GetComponentsInChildren<Rigidbody>());
        Disable();
    }

    public void Enable()
    {
        foreach (var rb in _rigidbodies)
        {
            rb.isKinematic = false;
        }
    }

    public void Disable()
    {
        foreach (var rb in _rigidbodies)
        {
            rb.isKinematic = true;
        }
    }
    
}
