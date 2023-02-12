using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitField : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ball") {
            Debug.Log("HitField had a collision with a Ball" + collision);
        }
    }
}
