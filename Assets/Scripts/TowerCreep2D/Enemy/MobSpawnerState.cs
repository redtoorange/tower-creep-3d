using System;

namespace TowerCreep2D.Enemy
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