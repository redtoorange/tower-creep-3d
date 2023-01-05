using Cinemachine;
using UnityEngine;

namespace TowerCreep3D.Player
{
    public enum PlayerCameraState
    {
        ThirdPerson,
        TopDown,
        Transitioning
    }

    public class PlayerCameraSwitcher : MonoBehaviour
    {
        private PlayerCameraState currentCameraState = PlayerCameraState.ThirdPerson;

        [SerializeField] private CinemachineBrain cinemachineBrain;
        [SerializeField] private CinemachineVirtualCamera thirdPersonCamera;
        [SerializeField] private CinemachineVirtualCamera topDownCamera;

        private void Start()
        {
            PlayerInputProcessor.OnCameraSwap += OnSwapCamera;
        }

        public void OnSwapCamera()
        {
            if (currentCameraState == PlayerCameraState.ThirdPerson)
            {
                thirdPersonCamera.gameObject.SetActive(false);
                topDownCamera.gameObject.SetActive(true);
                currentCameraState = PlayerCameraState.TopDown;

                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
            }
            else if (currentCameraState == PlayerCameraState.TopDown)
            {
                thirdPersonCamera.gameObject.SetActive(true);
                topDownCamera.gameObject.SetActive(false);
                currentCameraState = PlayerCameraState.ThirdPerson;

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}