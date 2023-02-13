using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitField : MonoBehaviour
{
    [SerializeField]
    private string text;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private GameObject hitText;

    private ShowText showText;

    void Start() {
        showText = hitText.GetComponent<ShowText>();
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.GetComponent<Ball>() != null) {
            showText.SetText(text);
            if (audioSource != null) {
                audioSource?.Play();
            }
        }
    }
}
