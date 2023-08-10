using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetoplayer : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject = GameObject.FindWithTag("Player");
        // Vector3 v3 = (gameObject.transform.position - transform.position).normalized;
        // Vector2 v2 = new Vector2(v3.x, v3.y);
        if(gameObject!= null)
        {
            Vector2 playerpos = (gameObject.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = playerpos * speed;
        }
    }
}
