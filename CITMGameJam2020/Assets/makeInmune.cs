using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeInmune : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.GetComponent<Player>().GodMode = true;
        }
    }
}
