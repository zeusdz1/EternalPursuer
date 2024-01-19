using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAnimationController : MonoBehaviour
{
    
    private Animator animator;

    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogError("Animator component not found on GameObject.");
        }
    }

    void Update()
    {
        // Check if the character is currently playing an idle animation
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            // Play the idle animation
            PlayIdleAnimation();
        }
    }

    void PlayIdleAnimation()
    {
        // Set trigger parameter for the "Idle" animation in the Animator
        animator.SetTrigger("Idle");
    }
}
