using System;

namespace TowerCreep2D.Player
{
    /// <summary>
    /// Resource types that the player can gain
    /// </summary>
    [Serializable]
    public enum PlayerResourceType
    {
        Mana,
        Energy,
        Gold,
        Experience,
        Health
    }
}