using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy",menuName = "Hacker Objects/Enemies/Enemy",order = 1)]
public class EnemyData : ScriptableObject
{
    public new string name;

    public GameObject enemySprite;
    
    public int health = 20, damage = 5;

    public float speed, detectRange, jumpForce;
}
