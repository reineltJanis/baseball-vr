using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundXYZ : MonoBehaviour
{

    [Tooltip("Speed of rotation in degrees per second")]
    [SerializeField]
    private float _speed;

    // Start is called before the first frame update
    public void Start()
    {
        // reset to 0 rotation
        transform.Rotate(Vector3.zero);
    }

    // Update is called once per frame
    public void Update()
    {
        float degrees = _speed*Time.deltaTime;
        transform.Rotate(degrees * Vector3.one);
    }
}
