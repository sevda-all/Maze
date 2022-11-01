using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    float dirX, dirY;
    public float moveSpeed = 5f;
    Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis ("Horizontal");
        dirY = Input.GetAxis ("Vertical");

    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2 (dirX * moveSpeed, dirY * moveSpeed);
    }
}
