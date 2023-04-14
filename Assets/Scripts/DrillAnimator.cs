using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillAnimator : MonoBehaviour
{
    Animator animator;
    public PlayerHealth script_ref;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(script_ref.IsAttacking == true)
        {
            animator.SetBool("IsAttacking", true);
        }

        if(script_ref.IsAttacking == false)
        {
            animator.SetBool("IsAttacking", false);
        }
    }
}
