using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private string enemyName;
    [SerializeField] private int baseAttack;
    [SerializeField] protected float moveSpeed;
}
