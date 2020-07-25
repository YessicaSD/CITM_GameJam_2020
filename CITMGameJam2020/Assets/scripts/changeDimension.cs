using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeDimension : MonoBehaviour
{
    public GameObject backPath;
    public GameObject frontPath;
    public bool front = false;
   
    public Material materialFront;
    public Material materialBack;
    MeshRenderer PlayerRenderer;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRenderer = GetComponent<MeshRenderer>();
        SetMaterial();
    }
    public void SetMaterial()
    {
        if (front)
        {
            PlayerRenderer.material = materialFront;
        }
        else
        {
            PlayerRenderer.material = materialBack;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            if (front)
            {
               
                transform.position = new Vector3(backPath.transform.position.x, transform.position.y, transform.position.z);
                
                front = false;
               
            }
            else
            {
                transform.position = new Vector3(frontPath.transform.position.x, transform.position.y, transform.position.z);
                
                front = true;
            }
            SetMaterial();

        }
    }
}
