using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text text;
    public static int scoreAmount;
    public GameObject lockUI;
    public GameObject openUI;
    
    void Start () {
        text = GetComponent<Text> ();
        scoreAmount = 0;
    }

    void Update () {
        text.text = "" + scoreAmount;

      if(scoreAmount == 5)
        {
            lockUI.SetActive(false);
            openUI.SetActive(true);
        }
    }
}
