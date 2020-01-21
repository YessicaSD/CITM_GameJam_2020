using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1;
    Rigidbody rb;
     public float gravity = 0.5F;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 velocity = new Vector3(0, 0, horizontalInput * speed * Time.deltaTime);
        if (Input.GetKeyDown("space"))
            Physics.gravity *= -1; 
       
        transform.position += velocity;

    }
}
