using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            int i = SceneManager.GetActiveScene().buildIndex;
            Debug.Log(i);
            int maxLevels = SceneManager.sceneCountInBuildSettings;
            ++i;
            if(i>=maxLevels)
            {
                i = 0;
            }
            SceneManager.LoadScene(i);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            int i = SceneManager.GetActiveScene().buildIndex;
            int maxLevels = SceneManager.sceneCountInBuildSettings;
            --i;
            if (i < 0)
            {
                i = maxLevels;
            }
            SceneManager.LoadScene(i);
        }
    }
}
