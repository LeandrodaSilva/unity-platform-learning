using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMegaMan : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel = 5;
    private bool direita = true;
    public float jump = 500;
    private bool ground = true;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.parent = collision.collider.transform;
        ground = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        transform.parent = null;
        ground = false;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if(x == 0)
        {
            animator.SetBool("movimento", false);
        } else
        {
            animator.SetBool("movimento", true);
        }

        if (ground)
        {
            animator.SetBool("pulo", false);
        }
        else
        {
            animator.SetBool("pulo", true);
        }

        rbd.velocity = new Vector2(x * vel, rbd.velocity.y);

        if(direita && x < 0 || !direita && x > 0)
        {
            transform.Rotate(new Vector2(0, 180));
            direita = !direita;
        }

        if(Input.GetKeyDown(KeyCode.Space) && ground)
        {
            rbd.AddForce(new Vector2(0, jump));
        }
    }
}
