using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(matrixBlender))]
public class changeToPerspective : MonoBehaviour
{
    public Camera camera;
    public GameObject TargetPos;
    bool startMoving = false;
    bool transitionBack = false;
    GameObject startPos;
    public float speed;
    float time;

    //variables change perpective
    private Matrix4x4 ortho,
                        perspective;
    public float fov = 60f,
                        near = .3f,
                        far = 1000f
                        ;
   
    private matrixBlender blender;
    private bool orthoOn;
   
    // Start is called before the first frame update
    void Start()
    {
        startPos = new GameObject();

       
        ortho = Matrix4x4.Ortho(-camera.orthographicSize * camera.aspect, camera.orthographicSize * camera.aspect, -camera.orthographicSize, camera.orthographicSize, near, far);
        perspective = Matrix4x4.Perspective(fov, camera.aspect, near, far);
        camera.projectionMatrix = ortho;
        orthoOn = true;
        blender = camera.transform.GetComponent<matrixBlender>();


    }

    // Update is called once per frame
    void Update()
    {
        if(startMoving)
        {
            time += Time.time  * speed;
            camera.GetComponent<cameraRotate>().isChangingPerspective = true;

            camera.transform.position =  Vector3.Lerp(camera.transform.position, TargetPos.transform.position, time);
            camera.transform.rotation =  Quaternion.Lerp(camera.transform.rotation, TargetPos.transform.rotation, time);
            if (time >= 1.0F)
            {
                startMoving = false;
            }
        }
        if(transitionBack)
        {
            time += Time.time * speed;

            camera.transform.position = Vector3.Lerp(camera.transform.position, startPos.transform.position, time);
            camera.transform.rotation  = Quaternion.Lerp(camera.transform.rotation, startPos.transform.rotation, time);

            if (time >= 1.0F)
            {
                camera.GetComponent<cameraRotate>().isChangingPerspective = false;
                transitionBack = false;
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        startMoving = false;
        transitionBack = true;
        time = 0;
        blender.BlendToMatrix(ortho, 1f);
        if (other.tag == "Player")
        {
            other.GetComponent<movement>().perspectiveMode = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<movement>().perspectiveMode = true;
        }
        startMoving = true;
       
        time = 0;
        blender.BlendToMatrix(perspective, 1f);
        if (transitionBack == false)
        {
            startPos.transform.position = camera.transform.position;
            startPos.transform.rotation = camera.transform.rotation;
        }
        transitionBack = false;
    }
}
