using System.Collections.Generic;
using TowerCreep2D.Damage;
using UnityEngine;

namespace TowerCreep2D.Enemy.MonsterData
{
    [CreateAssetMenu(fileName = "Data", menuName = "TowerCreep/MonsterData", order = 1)]
    public class MonsterData : ScriptableObject
    {
        [SerializeField] public Sprite mobSprite;
        [SerializeField] public int mobHealth = 10;
        [SerializeField] public float mobSpeed = 50;
        [SerializeField] public int mobDamage = 1;
        [SerializeField] public int experienceValue = 1;

        [SerializeField] public List<DamageSink> damageSinks;
    }
}