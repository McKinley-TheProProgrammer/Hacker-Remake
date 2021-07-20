using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement2D : MonoBehaviour
{
    public float speed = 10;

    private const float maxSpeed = 20f;
    private Rigidbody2D rb;

    private Vector3 velDir;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector3 dir,bool normalize)
    {
        
        rb.velocity = dir * (speed * Time.deltaTime);
        if (normalize)
        {
            dir.Normalize();
        }
    }

    public Vector2 Move(float x, float y, bool normalize)
    {
        Vector3 movement = new Vector2(x, y);
        
        rb.velocity = normalize ? movement.normalized * speed  : movement;

        
        return rb.velocity * Time.fixedDeltaTime;
    }
    
    
    
}
