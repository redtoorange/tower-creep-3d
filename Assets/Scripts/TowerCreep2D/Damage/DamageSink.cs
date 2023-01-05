using System;

namespace TowerCreep2D.Damage
{
    [Serializable]
    public struct DamageSink
    {
        public DamageType defenseType;
        public DamageSubType defenseSubType;
        public float defensePercent;
    }
}