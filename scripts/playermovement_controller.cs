using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement_controller : MonoBehaviour
{

    public float speed = 10.0f;
    private Rigidbody2D rigidbody;
    private Animator animator;

    private Rigidbody2D rigidbody2;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h,v);

        rigidbody.velocity = dir.normalized * speed;

        GetComponent<Animator>().SetBool("isflyingleft", h < 0);
        GetComponent<Animator>().SetBool("isflyingright", h > 0);
        animator.SetBool("isflyingup", v > 0);
        animator.SetBool("isflyingdown", v < 0);
    }
}
