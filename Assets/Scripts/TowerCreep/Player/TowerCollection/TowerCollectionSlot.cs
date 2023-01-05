﻿using System.Collections.Generic;
using TowerCreep.Interface.HotBar;
using TowerCreep.Towers;
using TowerCreep.Towers.TowerLevelData;

namespace TowerCreep.Player.TowerCollection
{
    public class TowerCollectionSlot
    {
        public TowerHotBarSlot CollectionHotBarSlot { get; set; }
        public TowerData CollectionTowerData { get; private set; }
        public TowerProgressionData TowerProgressionData { get; private set; }
        public TowerLevelData TowerLevelData { get; private set; }
        public bool IsPlaced { get; set; }

        public void Initialize(TowerData data)
        {
            if (data)
            {
                CollectionTowerData = data;
                TowerProgressionData = new TowerProgressionData();
                TowerLevelData = TowerLevelDataManager.S.GetLevelData(data);
            }
        }

        public List<TowerLevelDataRecord> GetCurrentLevelRecordData()
        {
            return TowerLevelData.GetData(TowerProgressionData.CurrentLevel);
        }
    }
}