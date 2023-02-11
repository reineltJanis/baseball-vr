using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitcher : MonoBehaviour
{
    [SerializeField]
    private GameObject ballPrefab;

    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float interval = 10f;

    [SerializeField]
    private Transform target;
    private float timeout;

    // Start is called before the first frame update
    void Start()
    {
        timeout = interval;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeout > 0)
        {
            timeout -= Time.deltaTime;
            return;
        }

        SpawnBall();
        timeout = interval;
    }

    private void SpawnBall()
    {
        var ball = Instantiate(ballPrefab, gameObject.transform.position, Quaternion.identity);
        ball.transform.parent = gameObject.transform;
        ball.transform.LookAt(target);
        var rb = ball.GetComponent<Rigidbody>();
        rb.velocity = ball.transform.forward * speed;
    }
}
