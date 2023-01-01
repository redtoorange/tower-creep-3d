using System.Collections.Generic;
using TowerCreep2D.TowerCreep2D.Scripts.Interface.HotBar;
using TowerCreep2D.TowerCreep2D.Scripts.Towers;
using TowerCreep2D.TowerCreep2D.Scripts.Utility;
using UnityEngine;

namespace TowerCreep2D.TowerCreep2D.Scripts.Player.TowerCollection
{
    public class PlayerTowerCollectionManager : MonoBehaviour
    {
        private List<TowerCollectionSlot> playerTowerCollection;
        [SerializeField] private List<TowerData> debuggingInitialTowerData;
        private TowerHotBarController hotbar;

        private void Start()
        {
            List<TowerData> towerCollection = GameManager.S.GetTowerCollectionData();

            if (!ReferenceEquals(towerCollection, null))
            {
                SetTowerCollection(towerCollection);
            }
            else if (!ReferenceEquals(debuggingInitialTowerData, null) && debuggingInitialTowerData.Count > 0)
            {
                Debug.Log("Using debugging tower data");
                SetTowerCollection(debuggingInitialTowerData);
            }

            hotbar = FindObjectOfType<TowerHotBarController>();
            if (hotbar)
            {
                hotbar.Initialize(playerTowerCollection);
            }
        }

        public void SetTowerCollection(List<TowerData> selectedTowers)
        {
            playerTowerCollection = new List<TowerCollectionSlot>();
            for (int i = 0; i < selectedTowers.Count; i++)
            {
                TowerCollectionSlot newSlot = new TowerCollectionSlot();
                if (!ReferenceEquals(selectedTowers[i], null))
                {
                    newSlot.Initialize(selectedTowers[i]);
                }

                playerTowerCollection.Add(newSlot);
            }
        }
    }
}