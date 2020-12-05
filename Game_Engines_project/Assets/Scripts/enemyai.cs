using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyai : MonoBehaviour
{
    public float Health = 2f;
    public GameObject player;
    public GameObject gun;
 
    public NavMeshAgent agent;
  
   
    void Start()
    {
      
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
       
        agent.destination = player.transform.position;
        if (Health <= 0)
        {
            die();

        }
    }
  
    void die()
    {
        wavespawner.Enemiesalive--;
        Destroy(this.gameObject);
        Instantiate(gun.transform, transform.position, transform.rotation);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            character_script.health--;
        }
        if (other.gameObject.tag == "building")
        {
            die();
        }
    }

  
}
