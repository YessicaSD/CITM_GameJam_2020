using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
    public float maxSpeed;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
