using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour {
 
	// Speed rackets move
	public float speed = 30;
 
	void FixedUpdate(){
 
		// GetAxisRaw returns a value representing whether
		// W or Up (1), S or Down (-1), or Nothing (0)
		// are being pressed
		float vertDirection = Input.GetAxisRaw ("Vertical");
 
		// Set the velocity of the racket in the vertical direction
		// Velocity will be movement direction * speed
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, vertDirection) * speed;
	}
 
}