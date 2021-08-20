using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Enemy : MonoBehaviour, IHit
{
    [SerializeField] private Movement2D enemyMovement;
    [SerializeField] private float sineMovementFrequency = 5f;
    [SerializeField] private bool  normalizeDirection;
    
    [SerializeField] private EnemyData myData;
    
    private int hp;

    public int HP
    {
        get => hp;
        set => hp = value;
    }
    
    private Damage dmg;

    private float speed;
    void Start()
    {
        hp = myData.health;
        enemyMovement = GetComponent<Movement2D>();
        dmg = GetComponent<Damage>();

        speed = enemyMovement.GetSpeed;

    }

    public void OnHit()
    {
        hp -= dmg.TakeDamage(10);
    }

    void EnemyMovement()
    {
        speed = enemyMovement.GetSpeed;
        
        Vector2 v = Vector3.one;
        
        Vector2 linearMovement = enemyMovement.Move(-v.x * (speed + Time.time), 
            v.y * enemyMovement.SineWave(sineMovementFrequency,speed * .5f),
            false);
       
    }
    
    void Update()
    {
        if (hp <= 0)
        {
            gameObject.SetActive(false);
        }    
    }
    private void FixedUpdate()
    {
        EnemyMovement();
    }

    
}
