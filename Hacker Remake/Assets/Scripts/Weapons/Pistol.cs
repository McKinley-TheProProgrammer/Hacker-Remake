using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : WeaponBase2
{
    //[SerializeField] private Transform shootPoint;

    public override void Shoot()
    {
        GameObject bullet = Pooling.Instance.SpawnFromPool(bulletTag, shootPoint.transform.position, Quaternion.identity);
    }
}
