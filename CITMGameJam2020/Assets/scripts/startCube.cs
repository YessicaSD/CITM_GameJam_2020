using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCube : MonoBehaviour
{
    public generateCubes spawnBlue;
    public generateCubes spawnRed;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            spawnBlue.start = true;
            spawnRed.start = true;
          
        }
    }
}
