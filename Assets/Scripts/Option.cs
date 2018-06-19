using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour {

    public AudioSource sound;
    public void BackToMenu() {
        sound.Stop();
        sound.Play();
        SceneManager.LoadSceneAsync("MainMenu",mode:LoadSceneMode.Single);
    }

    public void TryAgain() { 
        sound.Stop();
        sound.Play();
        SceneManager.LoadSceneAsync("Level1",mode:LoadSceneMode.Single);
    }
}
