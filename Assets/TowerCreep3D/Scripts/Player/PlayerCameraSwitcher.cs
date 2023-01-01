using System.Collections.Generic;
using Cinemachine;
using TowerCreep.TowerCreep3D;
using UnityEngine;

namespace TowerCreep
{
    public class PlayerCameraSwitcher : MonoBehaviour
    {
        [SerializeField] private List<CinemachineVirtualCamera> cameras;
        private int cameraIndex = 0;

        private void Start()
        {
            PlayerInputProcessor.OnCameraSwap += OnSwapCamera;
        }

        public void OnSwapCamera()
        {
            cameras[cameraIndex].gameObject.SetActive(false);
            cameraIndex = (cameraIndex + 1) % cameras.Count;
            cameras[cameraIndex].gameObject.SetActive(true);
        }
    }
}