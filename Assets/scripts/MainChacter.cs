using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float speed = 2f;
    Vector2 motionVector;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }
    private void Update()
    {
        motionVector = new Vector2(Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"));
    }
    void FixedUpdate()
    {
        Move();

    }
    private void Move()
    {
        rb.velocity = motionVector * speed;
    }

}