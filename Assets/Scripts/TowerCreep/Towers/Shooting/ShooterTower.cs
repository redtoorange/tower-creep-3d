﻿using System.Collections.Generic;
using TowerCreep.Damage;
using TowerCreep.Player.TowerCollection;
using TowerCreep.Towers.TowerLevelData;
using UnityEngine;

namespace TowerCreep.Towers.Shooting
{
    public class ShooterTower : MonoBehaviour
    {
        [SerializeField] private TargetingPriority targetingPriority;

        private TowerRangeDetection towerRangeDetection;
        private TowerRangePreview towerRangePreview;

        [SerializeField] private float shootingDelay = 0.5f;
        [SerializeField] private Projectile projectilePrefab;

        private Attacker attacker;
        private List<Enemy.Enemy> allEnemiesInRange;
        private Enemy.Enemy currentEnemy;
        private float currentCooldown = 0.0f;

        private TowerProgressionData towerProgressionData;
        private TowerLevelData.TowerLevelData towerLevelData;

        private void Awake()
        {
            towerRangeDetection = GetComponentInChildren<TowerRangeDetection>();
            towerRangePreview = GetComponentInChildren<TowerRangePreview>();
        }

        private void Start()
        {
            allEnemiesInRange = new List<Enemy.Enemy>();
            attacker = GetComponent<Attacker>();

            Tower tower = GetComponent<Tower>();
            TowerCollectionSlot collectionSlot = tower.GetCollectionSlotData();

            towerProgressionData = collectionSlot.TowerProgressionData;
            towerProgressionData.OnTowerLevelChangeChange += ParseAttacks;
            towerLevelData = collectionSlot.TowerLevelData;

            ParseAttacks();
        }

        private void ParseAttacks()
        {
            List<TowerLevelDataRecord> records = towerLevelData.GetData(
                towerProgressionData.CurrentLevel
            );

            if (records.Count > 0)
            {
                float shotsPerMinute = records[0].Speed;
                float shotsPerSecond = shotsPerMinute / 60.0f;
                shootingDelay = 1.0f / shotsPerSecond;

                int range = Mathf.RoundToInt(records[0].Range);
                towerRangeDetection.SetRange(range);
                towerRangePreview.SetRange(range);
            }
        }

        private void OnEnable()
        {
            towerRangeDetection = GetComponentInChildren<TowerRangeDetection>();
            towerRangeDetection.OnEnemyHasEnteredRange += AddEnemy;
            towerRangeDetection.OnEnemyHasExitedRange += RemoveEnemy;

            Enemy.Enemy.OnDie += HandleEnemyDie;
        }

        private void OnDisable()
        {
            towerRangeDetection.OnEnemyHasEnteredRange -= AddEnemy;
            towerRangeDetection.OnEnemyHasExitedRange -= RemoveEnemy;
            towerProgressionData.OnTowerLevelChangeChange -= ParseAttacks;
            Enemy.Enemy.OnDie -= HandleEnemyDie;
        }

        private void Update()
        {
            // Cooldown ticks down to 0 or less
            if (currentCooldown > 0)
            {
                currentCooldown -= Time.deltaTime;
                return;
            }

            if (!ReferenceEquals(currentEnemy, null))
            {
                FireShot();
                currentCooldown = shootingDelay;
            }
        }

        private void FireShot()
        {
            if (!ReferenceEquals(attacker, null))
            {
                Projectile projectile = Instantiate(
                    projectilePrefab,
                    transform.position,
                    Quaternion.identity,
                    transform
                );
                projectile.FireAt(attacker.GetAttack(), currentEnemy);
            }
        }

        private void HandleEnemyDie(Enemy.Enemy enemy)
        {
            if (currentEnemy == enemy)
            {
                RemoveEnemy(enemy);
            }
        }

        private void AddEnemy(Enemy.Enemy enemy)
        {
            allEnemiesInRange.Add(enemy);
            if (currentEnemy == null)
            {
                FindClosestEnemy();
            }
        }

        private void RemoveEnemy(Enemy.Enemy enemy)
        {
            if (allEnemiesInRange.Contains(enemy))
            {
                allEnemiesInRange.Remove(enemy);
            }

            if (enemy == currentEnemy)
            {
                currentEnemy = null;
                FindClosestEnemy();
            }
        }

        private void FindClosestEnemy()
        {
            if (allEnemiesInRange.Count > 0)
            {
                currentEnemy = allEnemiesInRange[0];
                Vector2 position = transform.position;
                float closestDistance = Vector2.Distance(position, currentEnemy.transform.position);
                for (int i = 1; i < allEnemiesInRange.Count; i++)
                {
                    float tempDist = Vector2.Distance(position, allEnemiesInRange[i].transform.position);
                    if (tempDist < closestDistance)
                    {
                        closestDistance = tempDist;
                        currentEnemy = allEnemiesInRange[i];
                    }
                }
            }
        }
    }
}