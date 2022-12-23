using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumbu : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float jumpForce;
    float moveX;
    Animator animator;
    int maxJump = 2, jump;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpForce = speed + 3;

        animator = GameObject.FindGameObjectWithTag("AnimasiRorL").GetComponent<Animator>();
    }
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        moveX += inputX * speed * Time.deltaTime;
        transform.position = new Vector3(moveX, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space) && jump > 0)
        {
            rb.velocity = Vector3.up * jumpForce;
            jump--;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = Vector3.down * jumpForce;
        }
        if (inputX == 0)
        {
            animator.SetBool("Right", false);
            animator.SetBool("Left", false);
        }
        if (inputX > 0)
        {
            animator.SetBool("Right", true);
        }
        if (inputX < 0)
        {
            animator.SetBool("Left", true);
        }
    }

    void MoveRb()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = Vector3.down * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jumpForce;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            jump = maxJump;
        }
    }
}
