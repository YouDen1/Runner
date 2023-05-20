using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    public float JumpForce;

    public float FallForce;
    private int FallCount;

    public float Hp;

    private bool Grounded;
    public Transform GroundCheck;
    public float GroundRadius;
    public LayerMask WhatIsGround;

    public Animator anim;

    public Text HealthText;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        HealthText.text = Hp.ToString();
        if (Hp <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundRadius, WhatIsGround);

        if(Grounded == true)
        {
            anim.SetBool("onGround", false);
        }
        else
        {
            anim.SetBool("onGround", true);
        }

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        { 
            rb.velocity = Vector2.up * JumpForce;
            FallCount = 0;
        }
        if (Input.GetKeyDown(KeyCode.S) && FallCount != 1)
        {
            rb.velocity = Vector2.down * FallForce;
            FallCount += 1;
        }
    }

}
