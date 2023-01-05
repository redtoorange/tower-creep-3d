using System;

namespace TowerCreep2D.Towers.Shooting
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