using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchGravity : MonoBehaviour
{
 
    private void OnTriggerEnter(Collider other)
    {
        Physics.gravity *= -1;
    }
}
