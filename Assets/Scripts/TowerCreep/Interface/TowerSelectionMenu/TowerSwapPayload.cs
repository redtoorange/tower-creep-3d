﻿using TowerCreep.Interface.TowerSelectionMenu.SelectedTowerList;
using TowerCreep.Towers;

namespace TowerCreep.Interface.TowerSelectionMenu
{
    public class TowerSwapPayload
    {
        public TowerData towerData;
        public SelectedTowerSlot sourceSlot;

        public TowerSwapPayload(TowerData towerData, SelectedTowerSlot sourceSlot)
        {
            this.towerData = towerData;
            this.sourceSlot = sourceSlot;
        }
    }
}