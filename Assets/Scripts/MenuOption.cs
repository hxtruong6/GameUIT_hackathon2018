using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOption : MonoBehaviour
{
    public AudioSource sound;
    public void PlayGame()
    {
        sound.Stop();
        sound.Play();
        SceneManager.LoadSceneAsync("Level1", mode: LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
