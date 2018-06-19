using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rigitMonster;
    public AudioSource soundJump;
    public AudioSource soundDie;
    public float timeJump = 6f;
    public Animator aniMonster;
    public GameObject currentFloor;
    public float force;
  

    private GameObject lastFloor;

    // time of the jump of monster
    private float timer;

    private bool overGame;
    private bool isOnFloor;
    private float timeLoadSceneDie;

    // Use this for initialization
    void Start()
    {
        overGame = false;
        isOnFloor = true;
        lastFloor = currentFloor;
        timer = 0;
        timeLoadSceneDie = 2f;
    }

    [ContextMenu("ADD FORCE")]
    public void AddForce()
    {
        this.rigitMonster.AddForce(new Vector3(0, 187, -187));
    }

    // Update is called once per frame
    void Update()
    {
        if (overGame)
        {
            timeLoadSceneDie -= Time.deltaTime;
            if (timeLoadSceneDie <= 0)
            {
                SceneManager.LoadSceneAsync("AgainMenu", LoadSceneMode.Single);
            }
        }
        else
        {


            if (Input.GetMouseButtonDown(0) && isOnFloor)
            {
                //transform.parent = parentPos;  // Make this object can use physic
                isOnFloor = false;
                //AddForce();
                rigitMonster.AddForce(new Vector3(0, 1, -1) * force);
                soundJump.Stop();
                soundJump.Play();
                timer = 0;
            }

            if (!isOnFloor)
            {
                timer += Time.deltaTime;
                Debug.Log(timer);
                if (timer >= timeJump)
                {
                    aniMonster.SetTrigger("Die");
                    soundDie.Stop();
                    soundDie.Play();
                    overGame = true;
                   


                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            if (lastFloor != collision.gameObject)
            {
                lastFloor = currentFloor;
                currentFloor = collision.gameObject;
                FloorRotation floor = currentFloor.GetComponentInParent<FloorRotation>();
                if (floor != null)
                {
                    floor.isRotation = false;
                }

                // Update Score
                ScoreManager.score += 10;
            }

          
            this.rigitMonster.velocity = Vector3.zero;
            isOnFloor = true;
            timer = 0;
        }

    }

}

