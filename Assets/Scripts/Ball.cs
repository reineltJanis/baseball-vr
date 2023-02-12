using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private bool wasHit = false;
    private Rigidbody rb;
    private TrailRenderer tr;

    private float timeout = 7f;

    private string hitFieldTag = "HitField";

    void Start() {

        rb = gameObject.GetComponent<Rigidbody>();
        tr = gameObject.GetComponent<TrailRenderer>();
        tr.enabled = false;
    }

    void Update(){
        if (!wasHit){
            rb.useGravity = false;
            // rb.velocity = Vector3.Scale(rb.velocity, new Vector3(1,0,1));
        }

        timeout -= Time.deltaTime;

        if (timeout <= 0){
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (wasHit)
            return;


        wasHit = rb.useGravity = true;

        if (collision.gameObject.tag == "Bat") {
            tr.enabled = true;
        }

        // if (collision.relativeVelocity.magnitude > 2)
        // audioSource.Play();
    }
}
