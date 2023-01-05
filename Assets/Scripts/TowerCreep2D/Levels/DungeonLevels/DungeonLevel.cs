using System;
using TowerCreep2D.Enemy;
using TowerCreep2D.Enemy.EnemyControllerEvents;
using TowerCreep2D.Interface.BuildPhase;
using TowerCreep2D.Map.Doors;
using TowerCreep2D.Player;
using UnityEngine;

namespace TowerCreep2D.Levels.DungeonLevels
{
    public class DungeonLevel : MonoBehaviour
    {
        public Action OnDungeonLevelComplete;
        public Action OnPlayerExitedLevel;


        public static Action<DungeonLevel> OnPlayerEnteredLevel;

        [SerializeField] private EnemyController enemyController;
        [SerializeField] private DoorController doorController;
        [SerializeField] private PlayerSpawnPoint playerSpawnPoint;

        private void OnEnable()
        {
            doorController.OnPlayerHasEnteredRoom += HandlePlayerEnteredRoom;
            doorController.OnPlayerHasExitedRoom += HandlePlayerExitedRoom;

            EnemyController.OnEnemyControllerEvent += HandleEnemyControllerEvent;
            BuildPhaseController.OnBuildPhaseComplete += StartLevel;
        }

        private void OnDisable()
        {
            EnemyController.OnEnemyControllerEvent -= HandleEnemyControllerEvent;
            BuildPhaseController.OnBuildPhaseComplete -= StartLevel;
        }


        private void HandlePlayerExitedRoom()
        {
            doorController.LockAllDoors();
            OnPlayerExitedLevel?.Invoke();
        }

        private void HandlePlayerEnteredRoom()
        {
            doorController.LockAllDoors();
            OnPlayerEnteredLevel?.Invoke(this);
        }


        private void HandleEnemyControllerEvent(EnemyControllerEvent ece)
        {
            if (ece.controller == enemyController && ece.type == EnemyControllerEventType.AllWavesComplete)
            {
                OnDungeonLevelComplete?.Invoke();
            }
        }

        public void StartLevel()
        {
            enemyController.StartSpawningMonsters();
        }

        public void TeleportPlayer(PlayerController playerController, PlayerCamera playerCamera)
        {
            Vector3 position = playerSpawnPoint.transform.position;
            playerController.transform.position = position;
            playerCamera.Teleport(position);
        }
    }
}