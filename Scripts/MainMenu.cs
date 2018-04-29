using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
    public void PlayeGame()
    {
        SceneManager.LoadScene("seen2");
        Time.timeScale=1f;

    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
