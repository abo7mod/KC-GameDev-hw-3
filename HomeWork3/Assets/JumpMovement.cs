using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMovement : MonoBehaviour
{
    bool nojump = true;
    public Animator playerAnimator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        nojump = true;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && nojump == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
            nojump = false;
        }
        if (nojump)
        {
            playerAnimator.SetBool("jump", false);

        }
        else
        {
            playerAnimator.SetBool("jump", true);
        }

    }
}
