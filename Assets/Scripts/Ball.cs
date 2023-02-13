using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private bool wasHit = false;
    private Rigidbody rb;
    private TrailRenderer tr;

    private float timeout = 7f;

    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
        tr = gameObject.GetComponent<TrailRenderer>();
        tr.enabled = false;
    }

    void Update(){
        if (!wasHit){
            rb.useGravity = false;
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

        if (collision.gameObject.GetComponent<Bat>() != null) {
            tr.enabled = true;
        }
    }
}
