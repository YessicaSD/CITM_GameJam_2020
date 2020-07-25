using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool GodMode = false;
    changeDimension changedmScript = null;
    changeGravity gravityScript = null;
    bool isFrontAtStart = false;
    private void Start()
    {
        changedmScript = GetComponent<changeDimension>();
        if(changedmScript!=null)
        {
            isFrontAtStart = changedmScript.front;
        }
        gravityScript = GetComponent<changeGravity>();
    }
    public void Reset()
    {
        if(changedmScript!=null)
        {
            changedmScript.front = isFrontAtStart;
            changedmScript.SetMaterial();
        }
        if(gravityScript != null)
        {
            gravityScript.gravityMode = true;
        }
    }
}
