using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathPlayer : MonoBehaviour
{
    Vector3 initialPosition;
    Quaternion initialRotation;

    public GameObject text;
    public string uiText;

    float textTimer;
    float textTime = 4.0f;
    bool timerOn = false;
    public cameraRotate camRotate;

    Player player;
    private void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
        player = GetComponent<Player>();
    }

    private void Update()
    {
      
            if (timerOn && (Time.time - textTimer > textTime))
            {
                Color color = text.GetComponent<Text>().color;
                color.a -= Time.deltaTime;
                text.GetComponent<Text>().color = color;

                if (color.a == 0)
                {
                    timerOn = false;
                }
            }
       
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Death" && !player.GodMode)
        {
            if(text!=null)
            {
                text.GetComponent<Text>().text = uiText;
                textTimer = Time.time;
                timerOn = true;
            }
            player.Reset();
            transform.SetPositionAndRotation(initialPosition, initialRotation);
           
            if(Physics.gravity.y > 0)
            {
                Physics.gravity *= -1;
            }

            if(camRotate!=null)
            {
                camRotate.actualCamera = 0;
                camRotate.move = true;
                camRotate.lerpPos = 0;
            }

            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
