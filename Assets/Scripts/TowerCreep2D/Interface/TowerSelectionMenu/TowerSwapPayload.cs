using TowerCreep2D.Interface.TowerSelectionMenu.SelectedTowerList;
using TowerCreep2D.Towers;

namespace TowerCreep2D.Interface.TowerSelectionMenu
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