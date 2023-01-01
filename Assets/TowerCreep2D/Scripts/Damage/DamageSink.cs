using System;

namespace TowerCreep2D.TowerCreep2D.Scripts.Damage
{
    [Serializable]
    public struct DamageSink
    {
        public DamageType defenseType;
        public DamageSubType defenseSubType;
        public float defensePercent;
    }
}