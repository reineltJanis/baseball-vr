using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private bool wasHit = false;
    private Rigidbody rb;

    private float timeout = 7f;

    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
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

        Debug.Log(collision);
        wasHit = rb.useGravity = true;

        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        // if (collision.relativeVelocity.magnitude > 2)
        // audioSource.Play();
    }
}
