using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : WeaponBase2
{
    
    public WeaponData weaponProps;

    //[SerializeField] private Transform shootPoint;

    public override void Shoot()
    {
        Pooling.Instance.SpawnFromPool("BALLS", shootPoint.transform.position, Quaternion.identity);
    }
}
