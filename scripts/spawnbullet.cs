using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnbullet : MonoBehaviour
{

    public GameObject bullet;
    public float interval = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shootbullet", interval, interval);
    }

    // Update is called once per frame
    private void shootbullet()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
