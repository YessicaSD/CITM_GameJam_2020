using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1;
    [HideInInspector] public bool perspectiveMode = false;

    public float gravityMultiplier = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityMultiplier;
    }

    void FixedUpdate()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 velocity = transform.forward * horizontalInput * speed * Time.deltaTime;

        transform.localPosition += velocity;
    }
}
