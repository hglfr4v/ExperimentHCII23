using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerScene4Man : MonoBehaviour
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

       if(Input.GetButtonDown("5Key")){
            animator.SetInteger("SpeakingCounterMan", 5);
            animator.SetBool("isSpeakingMan1", true);
            questions[0].Play();
        }
        if(Input.GetButtonDown("6Key")){
            animator.SetInteger("SpeakingCounterMan", 6);
            animator.SetBool("isSpeakingMan2", true);
            questions[1].Play();
        }
        if(Input.GetButtonDown("7Key")){
            animator.SetInteger("SpeakingCounterMan", 7);
            animator.SetBool("isSpeakingMan3", true);
            questions[2].Play();
        }
        if(Input.GetButtonDown("8Key")){
            animator.SetInteger("SpeakingCounterMan", 8);
            animator.SetBool("isSpeakingMan4", true);
            questions[3].Play();
        }
        if (questions[0].isPlaying)
        {
            animator.SetBool("isSpeakingMan1", true);
        } else {
            animator.SetBool("isSpeakingMan1", false);
        }
        if (questions[1].isPlaying)
        {
            animator.SetBool("isSpeakingMan2", true);
        } else {
            animator.SetBool("isSpeakingMan2", false);
        }
        if (questions[2].isPlaying)
        {
            animator.SetBool("isSpeakingMan3", true);
        } else {
            animator.SetBool("isSpeakingMan3", false);
        }
        if (questions[3].isPlaying)
        {
            animator.SetBool("isSpeakingMan4", true);
        } else {
            animator.SetBool("isSpeakingMan4", false);
        }
    }
}
