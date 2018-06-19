using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinRotation : MonoBehaviour
{
    public float speed = 2f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, speed, 0);
    }
}
