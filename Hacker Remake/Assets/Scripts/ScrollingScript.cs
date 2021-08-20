using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingScript : MonoBehaviour
{

    [SerializeField] private float scrollSpeed = 3f;
    [SerializeField] private float resetDistance = 20f; //the distance to reset the position
    
    private Vector2 startPos;

    [SerializeField] private Vector2 scrollDirection = Vector2.left;
    void Start()
    {
        startPos = transform.position; //registra a posição inicial do objeto de fundo
    }

    void ScrollingLoop(Vector2 dir, float length)
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, length);
        transform.position = startPos + dir * newPos;
    }
    void Update()
    {
        ScrollingLoop(scrollDirection, resetDistance);
    }
}
