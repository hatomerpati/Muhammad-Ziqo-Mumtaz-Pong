using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeedController : MonoBehaviour
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
            paddle1.GetComponent<PaddleController>().ActivatePUPaddleSpeed(); 
            paddle2.GetComponent<PaddleController>().ActivatePUPaddleSpeed(); 
            manager.RemovePowerUp(gameObject); 
        }     
    } 
}
