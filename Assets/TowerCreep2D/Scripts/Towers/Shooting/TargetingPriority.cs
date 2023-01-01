using System;

namespace TowerCreep2D.TowerCreep2D.Scripts.Towers.Shooting
{
    [Serializable]
    public enum TargetingPriority
    {
        ClosestFirst,
        FarthestFirst,
        WeakestFirst,
        StrongestFirst,
        MostHealth,
        LeastHealth
    }
}