using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", order = 1, menuName = "Hacker Objects/Weapon")]
public class WeaponData : WeaponBase
{
    public string weaponName;

    public int weaponAmmo , weaponDamage = 10;

    public float fireRate = .5f;
    public bool infiniteAmmo;
    
    public GameObject weaponSprite, weaponBullet;

    //public Transform weaponShootPoint;
    public override void Shoot()
    {
        Debug.Log("Shooting from");
        GameObject bullet = Pooling.Instance.SpawnFromPool("BALLS", weaponSprite.transform.GetChild(0).position, Quaternion.identity);
        
    }
}

