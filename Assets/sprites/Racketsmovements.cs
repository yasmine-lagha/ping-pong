using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Update is called once per frame
public class Racketsmovements : MonoBehaviour     
{	
	public float speed = 30;
public string axis;
void FixedUpdate () {
	//This is our GetAxisRaw input 
	float v = Input.GetAxisRaw(axis) * speed;
	
	//Just calling the Rigidbody2D component to change its Velocity value
	GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);
}
}