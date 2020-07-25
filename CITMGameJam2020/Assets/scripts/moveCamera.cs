using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public GameObject player;
    public GameObject actualCamera;
    public GameObject newCamera;
    public GameObject newPos;

    bool onPressed = false;
    float lerpPos = 0.0f;
    float speedCamera = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (onPressed)
        {
            lerpPos += Time.deltaTime;
            Helper.LerpTransform(actualCamera.transform, newCamera.transform, lerpPos, speedCamera);

            if ((newCamera.transform.position - actualCamera.transform.position).magnitude < 3)
            {
                player.transform.position = newPos.transform.position;
            }

            if (newCamera.transform.position == actualCamera.transform.position)
            {
                onPressed = false;
                player.transform.Rotate(new Vector3(0, 90, 0));
            }
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        onPressed = true;
    }
}
