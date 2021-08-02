using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private float dmgRadius = .4f;

    private int hpLoss;
    public int TakeDamage(int dmgAmount)
    {
        Collider2D[] checkHitbox = Physics2D.OverlapCircleAll(transform.position, dmgRadius);
        foreach(Collider2D hit in checkHitbox)
        {
            if (hit != null)
            {
                print($"Damaged {checkHitbox.First()} with {dmgAmount} damage");
                
            }
        }

        return dmgAmount;
    }

   
}
