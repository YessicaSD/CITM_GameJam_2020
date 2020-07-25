using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLight : MonoBehaviour
{
    public List<Light> lights;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            if (Physics.gravity.y > 0)
            {
                foreach (Light light in lights)
                {
                    light.color = Color.blue;
                }
            }
            else
            {
                foreach (Light light in lights)
                {
                    light.color = Color.red;
                }
            }
        }
        
    }
}
