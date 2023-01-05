using TowerCreep2D.Levels.DungeonLevels;
using UnityEngine;

namespace TowerCreep2D.Levels.DungeonCorridors
{
    public class DungeonCorridor : MonoBehaviour
    {
        private DungeonLevel northLevel;
        private DungeonLevel southLevel;

        public void Initialize(
            DungeonLevel northLevel,
            DungeonLevel southLevel
        )
        {
            this.northLevel = northLevel;
            this.southLevel = southLevel;
        }
    }
}