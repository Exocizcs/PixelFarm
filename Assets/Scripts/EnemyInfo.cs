using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/Enemy Data")]
public class EnemyInfo : ScriptableObject
{
    [SerializeField] private float _chaseRadius;
    [SerializeField] private float _attackRadius;
    public float chaseRadius => _chaseRadius;
    public float attackRadius => _attackRadius;
}