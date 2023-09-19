using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Block : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D coll) {
    	if(coll.collider.CompareTag("Ball")){
            Destroy(gameObject);
            GameManager.Score();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
