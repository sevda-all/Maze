using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Points : MonoBehaviour
{   
    
    public static int scoreAmount;


    void OnTriggerEnter2D(Collider2D col)
    {
        Score.scoreAmount +=1;
        Destroy(gameObject);
    }
    

}
