using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontal;
    private bool isFacingRight = true;
    private Animator animator;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();    
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);

        this.rb.velocity = new Vector2(horizontal *8f, this.rb.velocity.y);

        animator.SetFloat("speed",Mathf.Abs(horizontal));

    }

}