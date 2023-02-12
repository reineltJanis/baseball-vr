using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitField : MonoBehaviour
{

    private float timeout = 2f;
    private TMP_Text homeRunText;

    private AudioSource audioSource;
    private Animator animator;

    void Start() {
        homeRunText = GameObject.Find("HomeRunText").GetComponent<TMP_Text>();
        animator = homeRunText.GetComponent<Animator>();
        homeRunText.enabled = false;
        animator.enabled = false;

        audioSource = GetComponent<AudioSource>();
    }

    void Update(){
        timeout -= Time.deltaTime;

        if (timeout <= 0){
            homeRunText.enabled = false;
            animator.enabled = false;
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ball") {
            audioSource.Play();
            homeRunText.enabled = true;
            animator.enabled = true;
            timeout = 2f;
        }
    }
}
