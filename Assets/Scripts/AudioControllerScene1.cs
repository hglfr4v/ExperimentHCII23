using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerScene1 : MonoBehaviour
{
    
    public AudioSource[] questions;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("1Key")){
            questions[0].Play();
        }
        if(Input.GetButtonDown("2Key")){
            questions[1].Play();
        }
        if(Input.GetButtonDown("3Key")){
            questions[2].Play();
        }
        if(Input.GetButtonDown("4Key")){
            questions[3].Play();
        }
        if(Input.GetButtonDown("5Key")){
            questions[4].Play();
        }
        if(Input.GetButtonDown("6Key")){
            questions[5].Play();
        }
        if(Input.GetButtonDown("7Key")){
            questions[6].Play();
        }
    }
}
