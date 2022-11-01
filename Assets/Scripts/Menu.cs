using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    int sceneIndex;
    public static bool GameIsPaused = false;
    public GameObject MenuUI;
    

    void Start(){
        sceneIndex = SceneManager.GetActiveScene ().buildIndex;
        Time.timeScale = 1f;
    }
     
    public void NewGame(){
        Debug.Log ("New Game!");
        MenuUI.SetActive(false);
        SceneManager.LoadScene(sceneIndex * 0);
        Time.timeScale = 1f;
    }

    public void PlayGame(){
        Debug.Log ("Play!");
        MenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void PauseGame(){
        Debug.Log ("Pause!");
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true; 
    }

    public void QuitGame(){
        Debug.Log ("Goodbye!");
        Application.Quit();
    }
}
