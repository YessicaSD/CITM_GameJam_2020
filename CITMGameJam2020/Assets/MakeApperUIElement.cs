using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeApperUIElement : MonoBehaviour
{
    public GameObject panel;
    public Vector3 defaultScale;
    private void Start()
    {
        panel.transform.localScale = new Vector3(0, 0, 0);
    }
    public void ClosePanel()
    {
        LeanTween.scale(panel, new Vector3(0, 0, 0), 0.5F);
    }
    public void OpenPanel()
    {
        LeanTween.scale(panel, defaultScale, 0.5F);

    }
    private void OnTriggerEnter(Collider other)
    {
        OpenPanel();
    }
    private void OnTriggerExit(Collider other)
    {
        ClosePanel();
    }

}
