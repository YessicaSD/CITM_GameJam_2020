using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switcherMovement : MonoBehaviour
{
    public string playerTag;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == playerTag)
        {
            other.transform.Rotate(new Vector3(0, -90, 0));
          
        }
    }
}
