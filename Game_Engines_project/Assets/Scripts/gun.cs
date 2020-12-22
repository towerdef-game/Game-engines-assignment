using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject barrel;
    public bool canshoot = true;
    public float rateoffire;
    public static int ammo = 5;
    public float an;

    // Start is called before the first frame update
    void Start()
    {
        ammo = 5;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0) && ammo > 0 && canshoot == true)
        {
            shoot();
            // Debug.Log(ammo);
        }
        if (ammo <= 0)
        {
           // Debug.Log("out of ammo");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
            Destroy(this.gameObject);
            
        }
    }

    void shoot()
    {
        Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
        ammo -= 1;
        canshoot = false;
        
        StartCoroutine(FireRate());
    }

   
    IEnumerator FireRate()
    {
        yield return new WaitForSeconds(rateoffire);
        canshoot = true;
    }
}
