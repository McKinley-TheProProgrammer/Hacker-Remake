using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement2D : MonoBehaviour
{
    [SerializeField] float speed = 10;

    private const float maxSpeed = 20f;

    public float GetSpeed => speed;
    
    private Rigidbody2D rb;

    private Vector3 velDir;


    private Vector2 startPos;
    void Awake()
    {
        startPos = transform.localPosition;
        rb = GetComponent<Rigidbody2D>();
        if (speed >= maxSpeed)
            speed = maxSpeed;
    }

    public void Move(Vector3 dir,bool normalize)
    {
        
        rb.velocity = dir * (speed * Time.deltaTime);
        if (normalize)
        {
            dir.Normalize();
        }
    }
    
    //A é a Amplitude, B é a sequencia
    public Vector2 SineMovement(float x, float y, float frequency, float amplitude, bool normalize)
    {
        Vector2 movementEquation = new Vector2(x, y);


        movementEquation *= Mathf.Sin(Time.time + frequency) * amplitude;
        

        rb.velocity = normalize ? movementEquation.normalized : movementEquation;
        
        return rb.velocity * Time.fixedDeltaTime;
    }

    public float SineWave(float frequency, float amplitude)
    {
        return Mathf.Sin(frequency + Time.time) * amplitude;
    }
    public float CosineWave(float frequency, float amplitude)
    {
        return Mathf.Cos(frequency + Time.time) * amplitude;
    }
    
    public Vector2 SinePattern(Vector2 dir,float frequency, float amplitude)
    {
        Vector2 movePatt = Vector2.one;

        dir.x = SineWave(frequency, amplitude);
        dir.y = SineWave(frequency, amplitude);

        return movePatt;
    }
    
    public Vector2 Move(float x, float y, bool normalize)
    {
        Vector3 movement = new Vector2(x, y);
        
        rb.velocity = normalize ? movement.normalized * speed  : movement;

        
        return rb.velocity * Time.fixedDeltaTime;
    }
    
    
    
}


