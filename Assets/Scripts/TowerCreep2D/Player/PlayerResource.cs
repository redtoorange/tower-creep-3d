using System;

namespace TowerCreep2D.Player
{
    [Serializable]
    public class PlayerResource
    {
        public int currentValue;

        public PlayerResource(int currentValue)
        {
            this.currentValue = currentValue;
        }
    }
}