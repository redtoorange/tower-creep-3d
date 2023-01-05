using UnityEngine;

namespace TowerCreep2D.Enemy.WaveData
{
    [CreateAssetMenu(fileName = "Data", menuName = "TowerCreep/WaveData", order = 1)]
    public class EnemyWaveData : ScriptableObject
    {
        [SerializeField] public Enemy enemyBasePrefab;
        [SerializeField] public MonsterData.MonsterData monsterData;
        [SerializeField] public int spawnCount = 10;
        [SerializeField] public float spawnInterval = 1.0f;
        [SerializeField] public int experienceCompletionValue = 0;
    }
}