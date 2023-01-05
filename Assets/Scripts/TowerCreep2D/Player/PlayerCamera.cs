using Cinemachine;
using UnityEngine;

namespace TowerCreep2D.Player
{
    public class PlayerCamera : MonoBehaviour
    {
        private CinemachineVirtualCamera virtualCamera;

        private void Start()
        {
            virtualCamera = GetComponent<CinemachineVirtualCamera>();
        }

        public void Teleport(Vector2 where)
        {
            virtualCamera.ForceCameraPosition(where, Quaternion.identity);
        }
    }
}