using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private KeyCode start = KeyCode.Space;
    private float speed = 7f;
    private Vector2 inicial;

    void OnCollisionEnter2D (Collision2D coll) {
    	if(coll.collider.CompareTag("Player")){
            //x da bola - x do player / tamanho do player
            float x = (transform.position.x - coll.transform.position.x) / coll.collider.bounds.size.x;

            //direção da bola
            Vector2 vel = new Vector2(x, 1).normalized;

            //velocidade da bola        
            rb2d.velocity = vel * speed;          
    	}
    }

    void ResetBall(){
    	rb2d.velocity = Vector2.zero;
        inicial.x = 0;
        inicial.y = -3.5f; 
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
        if(Input.GetKey(start)){
            rb2d.velocity = Vector2.up * speed;
        }
    }
}
