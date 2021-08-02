using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Enemy : MonoBehaviour, IHit
{
    [SerializeField] private EnemyData myData;

    private int hp;

    public int HP
    {
        get => hp;
        set => hp = value;
    }

    private Damage dmg;
    void Start()
    {
        hp = myData.health;
        dmg = GetComponent<Damage>();
    }

    public void OnHit()
    {
        hp -= dmg.TakeDamage(10);
    }
    
    void Update()
    {
        if (hp <= 0)
        {
            gameObject.SetActive(false);
        }    
    }
}
