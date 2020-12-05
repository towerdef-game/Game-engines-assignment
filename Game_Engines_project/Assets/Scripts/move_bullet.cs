using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_bullet : MonoBehaviour
{
    public float speed;
    public float damage = 1f;
  


    void Update()
    {
        transform.position += (transform.forward * Time.deltaTime * speed);
    }
   
    void OnCollisionEnter(Collision other)
    {
       

        if (other.gameObject.tag == "enemy")
        {
            //  other.gameObject.GetComponent<Rigidbody>
            other.gameObject.GetComponent<enemyai>().Health = -damage;
            Destroy(this.gameObject);
        }
        if (other.gameObject)
        {
         
            Destroy(this.gameObject);
          
        }

        if (other.gameObject)
        {
            Destroy(this.gameObject);
        }

        if (speed == 0)
        {
            Destroy(this.gameObject);
        }
    }
}

