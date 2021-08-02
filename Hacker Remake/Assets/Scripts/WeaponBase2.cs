using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase2 : MonoBehaviour
{
   public Transform shootPoint;
   public abstract void Shoot();
}
