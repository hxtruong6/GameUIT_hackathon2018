using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform targetPos;
    public float smoothTime = 5f;

    private Vector3 offset;
	// Use this for initialization
	void Start () {
	    offset = transform.position - targetPos.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    Vector3 target = targetPos.position + offset;
	    transform.position = Vector3.Lerp(transform.position, target, smoothTime*Time.deltaTime);
	}
}
