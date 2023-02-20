using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerScene4Woman : MonoBehaviour
{
    public AudioSource[] questions;
    public Animator animator;
    int counter;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

       if(Input.GetButtonDown("1Key")){
            animator.SetInteger("SpeakingCounter", 1);
            animator.SetBool("isSpeaking1", true);
            questions[0].Play();
        }
        if(Input.GetButtonDown("2Key")){
            animator.SetInteger("SpeakingCounter", 2);
            animator.SetBool("isSpeaking2", true);
            questions[1].Play();
        }
        if(Input.GetButtonDown("3Key")){
            animator.SetInteger("SpeakingCounter", 3);
            animator.SetBool("isSpeaking3", true);
            questions[2].Play();
        }
        if(Input.GetButtonDown("4Key")){
            animator.SetInteger("SpeakingCounter", 4);
            animator.SetBool("isSpeaking4", true);
            questions[3].Play();
        }
        if (questions[0].isPlaying)
        {
            animator.SetBool("isSpeaking1", true);
        } else {
            animator.SetBool("isSpeaking1", false);
        }
        if (questions[1].isPlaying)
        {
            animator.SetBool("isSpeaking2", true);
        } else {
            animator.SetBool("isSpeaking2", false);
        }
        if (questions[2].isPlaying)
        {
            animator.SetBool("isSpeaking3", true);
        } else {
            animator.SetBool("isSpeaking3", false);
        }
        if (questions[3].isPlaying)
        {
            animator.SetBool("isSpeaking4", true);
        } else {
            animator.SetBool("isSpeaking4", false);
        }
    }
}
