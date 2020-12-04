using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_script : MonoBehaviour
{
    public float walkingSpeed = 7.5f;
    public float roatateSpeed = 30f;
    public float jumpHeight = 1.0F;
    public float gravity = 20.0f;
    public Camera playerCamera;
    public static int health;
    float rotationX = 0;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;
    public float RotateSpeed = 30f;
    CharacterController characterController;
    Vector3 direction = Vector3.zero;
    public static int ammo = 5;
    public float bullets;
    public GameObject bullet;
    public GameObject barrel;
    public Transform hand;
    public GameObject gun;
    public bool canshoot = true;
    public float rateoffire;

    [HideInInspector]
    public bool canmove = true;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded)
        {


            direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            direction = transform.TransformDirection(direction);
            direction *= walkingSpeed;

            characterController.Move(direction * Time.deltaTime);
         
            if (Input.GetButton("Jump"))
                direction.y = jumpHeight;
        }

        direction.y -= gravity * Time.deltaTime;
        characterController.Move(direction * Time.deltaTime);

        if (Input.GetMouseButtonDown(0) && ammo >= 1 && canshoot == true)
        {
          //  shoot();

        }
        // Player and Camera rotation
        if (canmove)
         {
             rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
             rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
           transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
         }
    
        
        
     
    }
    void shoot()
    {
        Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
        ammo -= 1;
        canshoot = false;

        StartCoroutine(FireRate());
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gun")
        {
            Destroy(other.gameObject);
        GameObject gunnner =    Instantiate<GameObject>(gun, hand.position, hand.rotation);
            gunnner.transform.parent = hand.transform;
           
        }  
    }
    IEnumerator FireRate()
    {
        yield return new WaitForSeconds(rateoffire);
        canshoot = true;
    }
}
