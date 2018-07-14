using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collitionInfo)
    {
        if (collitionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }

}

