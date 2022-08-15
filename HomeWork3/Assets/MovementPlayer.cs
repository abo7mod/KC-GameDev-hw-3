using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementPlayer : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float runSpeed = 10.0f;
    public Animator playerAnimator;






    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal != 0f)
        {
            playerAnimator.SetBool("idel,", true);
            transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x) * horizontal, transform.localScale.y);
        }
        else
        {
            playerAnimator.SetBool("idel", false);
        }
        if (horizontal != 0f)
        {
            playerAnimator.SetBool("jump", false);

        }
        else
        {
            playerAnimator.SetBool("jump", true);
        }

    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, body.velocity.y);
    }
}