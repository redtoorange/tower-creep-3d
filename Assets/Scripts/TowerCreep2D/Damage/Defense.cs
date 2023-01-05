using System;
using System.Collections.Generic;

namespace TowerCreep2D.Damage
{
    [Serializable]
    public struct Defense
    {
        public List<DamageSink> DamageSinks;
    }
}