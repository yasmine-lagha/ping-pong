using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Update is called once per frame
public class gravityS: MonoBehaviour{   
	
    
	float gravity = 0f;
    // Update is called once per frame
    void Update()
    {
        gravity = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().gravityScale =gravity;
    }
    
    Vector2 speed;
    // Update is called once per frame
    void Start()
    {
        Vector2 speed = new Vector2(1, 1);
        GetComponent<Rigidbody2D>().velocity = speed;
   
  } 
  }
   
  
  