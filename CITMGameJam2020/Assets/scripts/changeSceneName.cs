using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneName : MonoBehaviour
{
    public string sceneName;
    bool changeScene = false;
    float startTime;
     float duration = 2;
    

    AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if(changeScene)
        {
            if((Time.time - startTime)>duration)
            {
                SceneManager.LoadScene(sceneName);
                changeScene = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && changeScene == false)
        {
            changeScene = true;
            audio.Play();
            startTime = Time.time;
            StartCoroutine(AudioFadeOut.FadeOut(audio, duration));
            
        }
    }
}
