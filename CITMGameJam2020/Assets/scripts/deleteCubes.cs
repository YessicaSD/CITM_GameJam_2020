using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteCubes : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Death")
        {
            Debug.Log("Hey");
            Destroy(other.gameObject);
        }
            
    }
}
