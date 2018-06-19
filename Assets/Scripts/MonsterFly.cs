using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFly : MonoBehaviour {

    public Transform target;
    public Vector3 distance = Vector3.zero;
    public float timer = 5f;
    public AnimationClip aniClip;

    private Vector3 offset;

    private Transform targetPos;
    private bool enableFollow = false;


    // Use this for initialization
    void Start() {
        offset = transform.position - target.position;
        offset = offset.normalized;
    }

    // Update is called once per frame
    void Update() {
        if (!enableFollow) {
            timer -= Time.deltaTime;
            if (timer <= 0) {
                transform.LookAt(target);
                targetPos = target;
                enableFollow = !enableFollow;
            }
        }
        else {
            transform.position = Vector3.Lerp(transform.position, target.position - distance, 0.05f);
        }
    }

    //public void SetPosMummyJump() {
    //    aniClip.events[0];
    //}
}
