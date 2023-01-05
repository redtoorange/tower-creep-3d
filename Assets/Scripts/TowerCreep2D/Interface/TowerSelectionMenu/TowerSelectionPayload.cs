using TowerCreep2D.Towers;

namespace TowerCreep2D.Interface.TowerSelectionMenu
{
    public class TowerSelectionPayload
    {
        public TowerData towerData;

        public TowerSelectionPayload(TowerData towerData)
        {
            this.towerData = towerData;
        }
    }
}