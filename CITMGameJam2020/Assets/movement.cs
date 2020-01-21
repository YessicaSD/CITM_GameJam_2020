using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1;
    Rigidbody rb;
     public float gravity = 0.5F;
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
       // rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
       // float verticalInput = Input.GetAxis("Vertical");
        Vector3 velocity = new Vector3(0, 0, horizontalInput * speed * Time.deltaTime);

        //transform.position += velocity;
        velocity += Physics.gravity * Time.deltaTime;
        controller.Move(velocity);
    }
}
