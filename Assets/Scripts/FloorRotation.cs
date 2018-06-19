using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRotation : MonoBehaviour
{
    public Transform root;
    public float speedSelfRotation = 2f;
    public float speedTargetRotation = 1f;
    public float radium = 5f;
    public bool isRotation;

    private float x, z;

    private float alpha = 0f;

   
    // private Vector3 offset;

    // Use this for initialization
    void Start() {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!isRotation) return;
        // Rotation self
        transform.Rotate(0, speedSelfRotation, 0);

        //// Rotation follow target


        //alpha += Time.deltaTime * speedTargetRotation;
        alpha += Time.deltaTime * speedTargetRotation;
        //Debug.Log(root.position + " "+ radium);
        x = root.position.x + radium * Mathf.Cos(alpha);
        z = root.position.z + radium * Mathf.Sin(alpha);

        transform.position = new Vector3(x, transform.position.y, z);

    }
}
