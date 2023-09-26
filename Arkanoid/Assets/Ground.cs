using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    void OnTriggerEnter2D (Collider2D hitInfo) {
        GameManager.PerderVida();
        hitInfo.gameObject.SendMessage("ResetBall", 1.0f, SendMessageOptions.RequireReceiver);
    }
}
