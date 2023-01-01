using System;

namespace TowerCreep2D.TowerCreep2D.Scripts.Enemy
{
    [Serializable]
    public enum MobSpawnerState
    {
        NotStarted,
        Idle,
        Spawning,
        Waiting,
        Cooldown,
        Done
    }
}