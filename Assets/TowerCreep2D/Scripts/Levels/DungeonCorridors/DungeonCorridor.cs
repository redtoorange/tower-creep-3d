using TowerCreep2D.TowerCreep2D.Scripts.Levels.DungeonLevels;
using UnityEngine;

namespace TowerCreep2D.TowerCreep2D.Scripts.Levels.DungeonCorridors
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