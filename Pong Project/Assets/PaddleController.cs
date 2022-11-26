using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    Vector2 movement = Vector2.zero;
    Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        
        GetObject(GetInput());
    }
    Vector2 GetInput ()
    {
        
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    void GetObject(Vector2 movement)
    {
        rig.velocity = movement;
    }

    public void ActivatePUPaddleUp(){
        transform.localScale = new Vector3(1.0f, 4.5f, 1.0f);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }


    internal void ActivatePUPaddleSpeed()
    {
        rig.velocity *= 1;
    }
}
