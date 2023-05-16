using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    public float JumpForce;

    private bool Grounded;
    public Transform GroundCheck;
    public float GroundRadius;
    public LayerMask WhatIsGround;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundRadius, WhatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            rb.velocity = Vector2.up * JumpForce;
        }
    }

}
