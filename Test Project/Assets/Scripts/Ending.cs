using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.completeLevel(); 
    }
}
