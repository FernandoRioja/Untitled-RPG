using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private Rigidbody2D rb;
    private Vector2 axisMovement;
    public Animator animator;
    Collider2D heroCollider;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        heroCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        axisMovement.x = Input.GetAxisRaw("Horizontal");
        axisMovement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = axisMovement.normalized * speed;
        
        Flip();
    }

    void Flip()
    {
        bool movingLeft = axisMovement.x < 0;
        bool movingRight = axisMovement.x > 0;
        bool isIdle = axisMovement.x == 0;

        if (movingLeft)
        {
            transform.localScale = new Vector3(-1f, transform.localScale.y);
            animator.SetFloat("isWalking", Mathf.Abs(axisMovement.x + axisMovement.y));

        }
        if (movingRight)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y);
            animator.SetFloat("isWalking", Mathf.Abs(axisMovement.x + axisMovement.y));

        }
        if (isIdle)
        {
            animator.SetFloat("isWalking", Mathf.Abs(axisMovement.x + axisMovement.y));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lv.1Bandit"))
        {
            Debug.Log("Tenes un desgarre anal");
        }
    }

}
