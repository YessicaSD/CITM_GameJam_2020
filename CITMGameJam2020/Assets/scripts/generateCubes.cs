using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateCubes : MonoBehaviour
{
    public bool start = false;
    public GameObject prefab;
    public float maxIntervalTime;
    float intervalTime;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
        intervalTime = maxIntervalTime * Random.Range(1.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - timer > intervalTime)
        {
            GenerateCube();
            timer = Time.time;
            intervalTime = maxIntervalTime * Random.Range(1.0f, 2.0f);
        }

    }

    void GenerateCube()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
