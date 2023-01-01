using TowerCreep2D.TowerCreep2D.Scripts.Interface.TowerSelectionMenu.SelectedTowerList;
using TowerCreep2D.TowerCreep2D.Scripts.Towers;

namespace TowerCreep2D.TowerCreep2D.Scripts.Interface.TowerSelectionMenu
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