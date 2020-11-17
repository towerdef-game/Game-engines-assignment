using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_script : MonoBehaviour
{
    public float walkingSpeed = 7.5f;
    public float roatateSpeed = 30f;
    public Camera playerCamera;
    CharacterController characterController;
    Vector3 direction = Vector3.zero;
    
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
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        direction = transform.TransformDirection(direction);
        direction *= walkingSpeed;

        characterController.Move(direction * Time.deltaTime);
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(-Vector3.up * roatateSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.up * roatateSpeed * Time.deltaTime);
    }
}
