using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollEnabler : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Transform ragdoll;
    [SerializeField] private bool isRagdollEnabled = false;

    public Rigidbody[] rigidbodies;
    private CharacterJoint[] joints;
    private Collider[] colliders;

    private void Awake()
    {
        rigidbodies = ragdoll.GetComponentsInChildren<Rigidbody>();
        joints = ragdoll.GetComponentsInChildren<CharacterJoint>();
        colliders = ragdoll.GetComponentsInChildren<Collider>();
    
        if (isRagdollEnabled)
        {
            EnableRagdoll();
        }
        else
        {
            EnableAnimator();
        }
    }

    public void EnableRagdoll()
    {
        animator.enabled = false;
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.velocity = Vector3.zero;
            rb.useGravity = true;
            rb.detectCollisions = true;
        }
        foreach (CharacterJoint joint in joints)
        {
            joint.enableProjection = true;
            // joint.enablecollision = true;
        }
        foreach (Collider col in colliders)
        {
            col.enabled = true;
        }
    }

    public void EnableAnimator()
    {
        animator.enabled = true;
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.useGravity = false;
            rb.detectCollisions = false;
        }
        foreach (CharacterJoint joint in joints)
        {
            joint.enableProjection = false;
            // joint.enablecollision = false;
        }
        foreach (Collider col in colliders)
        {
            col.enabled = false;
        }
    }
}
