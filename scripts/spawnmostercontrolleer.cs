using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmostercontrolleer : MonoBehaviour
{
    public GameObject monster1;
    public GameObject monster2;
    public float interval = 3;
    public float startinterval = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", startinterval, interval);
    }

    // Update is called once per frame
    private void SpawnMonster()
    {
        float myran = Random.value;
        if (myran < 0.2)
        {
            GameObject g = Instantiate(monster1, transform.position, Quaternion.identity);
        }
        else if(myran < 0.4)
        {
            GameObject g = Instantiate(monster2, transform.position, Quaternion.identity);
        }
    }
}
 