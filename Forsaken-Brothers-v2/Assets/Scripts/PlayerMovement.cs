using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Animator animator;
    public Rigidbody2D rb;
    public int durationSpeed = 10;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // Input

       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");
       animator.SetFloat("Horizontal", movement.x);
       animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        // player movement
        rb.MovePosition(rb.position + movement *moveSpeed *Time.fixedDeltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SpeedUp"))
        {
            moveSpeed = 8f;
            GetComponent<SpriteRenderer>().color = Color.blue;
            StartCoroutine(RestSpeed());
        }
    }


    private IEnumerator RestSpeed()
    {
        yield return new WaitForSeconds(durationSpeed);
        moveSpeed = 5f;
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
