using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class BulletMovement : MonoBehaviour , IHit
{
    public float speed;

    [SerializeField] float countdown = 2;

    
    private int countAux;
    private Transform bulletPos;

    [SerializeField] private int bulletHp = 30;
    private int hpAux;
    
    private Damage dmg;
    private void Awake()
    {
        //bulletPos = transform;
        hpAux = bulletHp;
        dmg = GetComponent<Damage>();
        countAux = (int)countdown;
    }

    void Update()
    {
        transform.position += transform.right * (speed * Time.deltaTime);
        
        Countdown();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            OnHit();
            other.GetComponent<Enemy>().OnHit();
        }
    }

    public void OnHit()
    {
        bulletHp -= dmg.TakeDamage(40);
        if (bulletHp <= 0)
        {
            bulletHp = hpAux;
            GameObject sfx = Pooling.Instance.SpawnFromPool("Explosion1", transform.position, Quaternion.identity);
            
            gameObject.SetActive(false);
        }
        //gameObject.SetActive(false);
        

        
    }
    void Countdown()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            countdown = countAux;
            gameObject.SetActive(false);
            
        }
    }
}
