using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionplayerwithmonster : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "monster")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
    private void OnDisable()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
