using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public KeyCode moveRight = KeyCode.RightArrow;
    public KeyCode moveLeft = KeyCode.LeftArrow;
    public float speed = 5.0f;
    public float boundX = 4.15f;
    private Vector2 inicial;


    void RestartGame(){
    	rb2d.velocity = Vector2.zero;
        inicial.x = 0;
        inicial.y = -4f; 
    	transform.position = inicial;
    }
	
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
    	if (Input.GetKey(moveRight)) {
        	vel.x = speed;
    	}
    	else if (Input.GetKey(moveLeft)) {
        	vel.x = -speed;
    	}
    	else {
        	vel.x = 0;
    	}
    	rb2d.velocity = vel;

        var pos = transform.position;
    	if (pos.x > boundX) {
        	pos.x = boundX;
    	}
   	    else if (pos.x < -boundX) {
        	pos.x = -boundX;
    	}
    	transform.position = pos;
	}
}
