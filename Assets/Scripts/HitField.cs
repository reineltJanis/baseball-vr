using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitField : MonoBehaviour
{
    private ShowText showText;

    [SerializeField]
    private string text;

    [SerializeField]
    private AudioSource audioSource;

    void Start() {
        showText = GameObject.Find("HomeRunText").GetComponent<ShowText>();
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ball") {
            showText.SetText(text);
            if (audioSource != null) {
                audioSource?.Play();
            }
        }
    }
}
