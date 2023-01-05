using System.Collections.Generic;
using TowerCreep2D.Player.TowerCollection;
using TowerCreep2D.Towers;
using TowerCreep2D.Towers.TowerLevelData;
using UnityEngine;

namespace TowerCreep2D.Damage
{
    public class Attacker : MonoBehaviour
    {
        [SerializeField] private List<DamageSource> damageSources;

        private Tower tower;
        private TowerCollectionSlot collectionSlot;
        private TowerProgressionData towerProgressionData;
        private TowerLevelData towerLevelData;

        private void Start()
        {
            tower = GetComponent<Tower>();
            collectionSlot = tower.GetCollectionSlotData();

            towerProgressionData = collectionSlot.TowerProgressionData;
            towerProgressionData.OnTowerLevelChangeChange += ParseAttacks;
            towerLevelData = collectionSlot.TowerLevelData;

            ParseAttacks();
        }

        private void ParseAttacks()
        {
            damageSources = new List<DamageSource>();
            List<TowerLevelDataRecord> records = towerLevelData.GetData(
                towerProgressionData.CurrentLevel
            );
            foreach (TowerLevelDataRecord record in records)
            {
                damageSources.Add(DamageSource.FromData(record));
            }
        }

        public Attack GetAttack()
        {
            return new Attack(this, damageSources);
        }
    }
}