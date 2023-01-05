using UnityEngine;

namespace TowerCreep2D.Map.Portals
{
    public class PortalController : MonoBehaviour
    {
        [SerializeField] private Portal spawnPortal;
        [SerializeField] private Portal exitPortal;

        private void Start()
        {
            exitPortal.ExitInitialize(spawnPortal);
        }
    }
}