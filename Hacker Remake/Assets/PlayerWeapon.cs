using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    public Pistol weaponEquipped;

    private float gunFireRate;

    private void Start()
    {
        gunFireRate = weaponEquipped.weaponProps.fireRate;
    }
    void PlayerShoot()
    {
        gunFireRate -= Time.deltaTime;
        if (gunFireRate < 0)
        {
            weaponEquipped.Shoot();
            ResetWeaponSettings();
        }
    }

    void ResetWeaponSettings()
    {
        gunFireRate = weaponEquipped.weaponProps.fireRate;
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           PlayerShoot();
           
        }       
    }
}
