using System;
using System.Collections.Generic;

namespace TowerCreep2D.Damage
{
    [Serializable]
    public struct Attack
    {
        public Attacker source;
        public List<DamageSource> DamageSources;

        public Attack(Attacker source, List<DamageSource> damageSources)
        {
            this.source = source;
            DamageSources = damageSources;
        }
    }
}