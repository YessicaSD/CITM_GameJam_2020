using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishCube : MonoBehaviour
{
    public generateCubes spawnBlue;
    public generateCubes spawnRed;
   
   
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            spawnBlue.start = false;
            spawnRed.start = false;
        }
    }
}
