using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalFloor : MonoBehaviour {

    public AudioSource winSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            winSound.Stop();
            winSound.Play();
            SceneManager.LoadSceneAsync("WinMenu", LoadSceneMode.Single);
        }
    }
}
