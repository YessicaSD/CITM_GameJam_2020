using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeGravity : MonoBehaviour
{
   [HideInInspector] public bool gravityMode = true;
    public AudioClip gravityFx;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && gravityMode)
        {
            Physics.gravity *= -1;
            gravityMode = false;
            GetComponent<AudioSource>().PlayOneShot(gravityFx);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            gravityMode = true;
        }
    }
}
