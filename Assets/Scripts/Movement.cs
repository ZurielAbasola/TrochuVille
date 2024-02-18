using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
// Summary:
// Represents the player's movement in the game.
//
public class Movement : MonoBehaviour
{
    //
    // Summary:
    // The speed of the player's movement;
    // default is 2.
    //
    public float speed = 2;

    public Animator animator;

    private Vector3 direction;

    // 
    // Summary:
    // Gets the player's input and moves the player.
    //
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        direction = new(horizontal, vertical);

        AnimateMovement(direction);
    }

    //
    // Summary:
    // Translate the player's position based on the direction and speed.
    //
    private void FixedUpdate()
    {
        this.transform.position += direction * speed * Time.deltaTime;
    }

    // 
    // Summary:
    // Animate the player's movement based on the direction.
    //
    void AnimateMovement(Vector3 direction)
    {
        if (animator != null)
        {
            if (direction.magnitude > 0)
            {
                animator.SetBool("isMoving", true);

                animator.SetFloat("horizontal", direction.x);
                animator.SetFloat("vertical", direction.y);
            }
            else 
            {
                animator.SetBool("isMoving", false);
            }
        }
    }
}
