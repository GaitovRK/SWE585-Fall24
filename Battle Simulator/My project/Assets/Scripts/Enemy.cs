using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover mover;
    [SerializeField] private EnemyView _enemyView;
    [SerializeField] private RagdollController _ragdollController;
    public float fallCheckDistance = 5.0f; // Distance to check for ground

    public void Initialize()
    {
        _enemyView.Initialize();
        _ragdollController.Initialize();
    }

    public void StartRun()
    {
        _enemyView.StartRunning();
        mover.Enable();
    }
    
    public bool IsGrounded()
    {
        // Cast a ray downwards to check for ground
        return Physics.Raycast(transform.position, Vector3.down, fallCheckDistance);
    }

    public void Fall()
    {
        _enemyView.DisableAnimator();
        mover.Disable();
        _ragdollController.Enable();

    }

    private void Update()
    {
    //     StartRun();

        if (!IsGrounded())
        {
            Fall();
        }
    }
}
