using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<Light>().enabled = true;
    }
}
