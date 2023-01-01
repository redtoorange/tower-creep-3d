using TowerCreep2D.TowerCreep2D.Scripts.Towers;

namespace TowerCreep2D.TowerCreep2D.Scripts.Interface.TowerSelectionMenu
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