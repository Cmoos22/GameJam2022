using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //https://www.youtube.com/watch?v=24-BkpFSZuI&ab_channel=bendux 
    // Youtuber Bendux (23-11-2022)

    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private float horizontal;
    private float speed = 10f;
    private float JumpingPower = 11f;
    private bool isFacingRight = true;

    // for relode to menu
    public string lOne = "Level 1";



    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if(!isFacingRight && horizontal > 0f)
        {
            Flip();
        }
        else if (!isFacingRight && horizontal < 0f)
        {
            Flip();
        }
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpingPower);
        }

        if(context.canceled && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.10f);
        }
    }



    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 1f, groundLayer);
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localeScale = transform.localScale;
        localeScale.x *= -1f;
        transform.localScale = localeScale;

    }
    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }

    public void OnDestroy()
    {
        FindObjectOfType<TimeManager>().LoadScene(lOne);
    }
}
