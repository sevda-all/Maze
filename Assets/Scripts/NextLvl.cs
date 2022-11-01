using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLvl : MonoBehaviour
{
    int sceneIndex;

    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene ().buildIndex;
        
    }
    void OnTriggerEnter2D (Collider2D coll)
    {
        SceneManager.LoadScene (sceneIndex + 1);
    }
    

}
