using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject theEndUI;

    void Start()
    {
        
        
    }
    void OnTriggerEnter2D (Collider2D coll)
    {
        theEndUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
