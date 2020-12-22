using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float bulletspeed;
    public float damage = 1f;
 
    public Transform player;
    private Vector3 target;
    private Vector3 sight;

 
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = player.position;

        sight = (target - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += sight * bulletspeed * Time.deltaTime;

    }


    void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.tag == "Player")
        {
            character_script.health--;
            Destroy(this.gameObject);
        }

        if (other.gameObject)
        {
            Destroy(this.gameObject);
        }
    }
}
