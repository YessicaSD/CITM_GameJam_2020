using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeText : MonoBehaviour
{
    float timer;
    public float time;
    bool startFade = false;

    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - timer > time)
        {
            startFade = true;
        }

        if(startFade)
        {
            Color color = GetComponent<Text>().color;
            color.a -= Time.deltaTime;
            GetComponent<Text>().color = color;

        }
    }
}
