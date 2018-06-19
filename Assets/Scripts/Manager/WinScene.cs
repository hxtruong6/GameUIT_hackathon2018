using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour {

    public AudioSource sound;

    public void BackToMenu() {
        sound.Stop();
        sound.Play();
        SceneManager.LoadSceneAsync("MainMenu",mode:LoadSceneMode.Single);
    }
}
