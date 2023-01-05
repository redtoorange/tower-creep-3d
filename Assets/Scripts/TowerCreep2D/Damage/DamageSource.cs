using System;
using TowerCreep2D.Towers.TowerLevelData;

namespace TowerCreep2D.Damage
{
    [Serializable]
    public struct DamageSource
    {
        public DamageType damageType;
        public DamageSubType damageSubType;
        public float damageMinAmount;
        public float damageMaxAmount;

        public static DamageSource FromData(TowerLevelDataRecord record)
        {
            return new DamageSource()
            {
                damageType = record.PrimaryType,
                damageSubType = record.SubType,
                damageMinAmount = record.MinDamage,
                damageMaxAmount = record.MaxDamage
            };
        }
    }
}