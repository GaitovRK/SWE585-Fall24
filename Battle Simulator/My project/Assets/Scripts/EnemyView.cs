using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    private const string IsRunningKey = "isRunning";

    private Animator animator;

    public void Initialize()
    {
        animator = GetComponent<Animator>();
    }

    public void StartRunning()
    {
        animator.SetBool(IsRunningKey, true);
    }

    public void StopRunning()
    {
        animator.SetBool(IsRunningKey, false);
    }

    public void DisableAnimator()
    {
        animator.enabled = false;
    }

    public void EnableAnimator()
    {
        animator.enabled = true;
    }
}
