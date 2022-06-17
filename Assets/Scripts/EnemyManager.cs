using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : EnemyAI
{
    [SerializeField] private EnemyInfo currentEnemy;
    [SerializeField] private Transform target;
    // Start is called before the first frame update
    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    private void Update()
    {
        CheckDistance();
    }
    private void CheckDistance()
    {
        if (Vector3.Distance(target.position, transform.position) <= currentEnemy.chaseRadius && Vector3.Distance(target.position, transform.position) > currentEnemy.attackRadius)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }
}
