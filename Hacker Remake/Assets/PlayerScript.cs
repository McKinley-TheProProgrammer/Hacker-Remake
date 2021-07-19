using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement2D))]
public class PlayerScript : MonoBehaviour
{
    
    private Movement2D movement2D;

    private void Start()
    {
        movement2D = GetComponent<Movement2D>();
    }

    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        //Vector3 mov = new Vector2(x,y);
        
        //movement2D.Move(mov,true);

        movement2D.Move(x, y, false);
    }
}
