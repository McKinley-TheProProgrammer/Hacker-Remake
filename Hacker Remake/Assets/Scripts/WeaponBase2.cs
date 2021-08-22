using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase2 : MonoBehaviour
{
   public WeaponData weaponProps;
   public Transform shootPoint;
   public string bulletTag = "BALAS";
   
   public abstract void Shoot();
}
