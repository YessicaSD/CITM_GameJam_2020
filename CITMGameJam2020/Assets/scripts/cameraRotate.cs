using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class Helper
{
    public static void LerpTransform(this Transform t1, Transform t2, float t, float speed)
    {
        t1.position = Vector3.Lerp(t1.position, t2.position, t * speed);
        t1.rotation = Quaternion.Lerp(t1.rotation, t2.rotation, t * speed);
        t1.localScale = Vector3.Lerp(t1.localScale, t2.localScale, t * speed);
    }
}

public class cameraRotate : MonoBehaviour
{
    public List<GameObject> cameraPos;
    public int actualCamera;
    [HideInInspector] public bool move = false;
    public float speedCamera = 2.0f;
    [HideInInspector] public float lerpPos = 0;
    Camera cam;
    movement player;
    public bool isChangingPerspective = false;
    public AudioClip fx_wind;


    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        //transform.SetParent(cameraPos[actualCamera].transform);
        if(cameraPos.Count>0)
        {
            transform.SetPositionAndRotation(cameraPos[actualCamera].transform.position, cameraPos[actualCamera].transform.rotation);

        }
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButtonDown("R1") || Input.GetKeyDown(KeyCode.UpArrow)) && !move && !player.perspectiveMode && !isChangingPerspective)
        {
            cam.orthographic  = true;
            if (actualCamera < cameraPos.Capacity - 1)
            {
                actualCamera++;
                player.transform.Rotate(new Vector3(0, -90, 0));
                move = true;
                GetComponent<AudioSource>().PlayOneShot(fx_wind);
            }
        }

        if ((Input.GetButtonDown("L1") || Input.GetKeyDown(KeyCode.DownArrow)) && !move && !player.perspectiveMode && !isChangingPerspective)
        {
            cam.orthographic = true;
            if (actualCamera >= 1)
            {
                actualCamera--;
                player.transform.Rotate(new Vector3(0, 90, 0));
                move = true;
                GetComponent<AudioSource>().PlayOneShot(fx_wind);
            }
        }

        if (move)
        {
            lerpPos += Time.deltaTime;
            Helper.LerpTransform(transform, cameraPos[actualCamera].transform, lerpPos, speedCamera);
            if(lerpPos>=1)
            {
                move = false;
                lerpPos = 0;
            }
           
                
        }
    }
}