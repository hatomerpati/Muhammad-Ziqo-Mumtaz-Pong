using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public GameObject paddle1;
    public GameObject paddle2;
    public float magnitude;
 
    private void OnTriggerEnter2D(Collider2D collision) 
    { 
        if (collision == ball) 
        { 
            paddle1.GetComponent<PaddleController>().ActivatePUPaddleUp(); 
            paddle2.GetComponent<PaddleController>().ActivatePUPaddleUp(); 
            manager.RemovePowerUp(gameObject); 
        }     
    } 
}

