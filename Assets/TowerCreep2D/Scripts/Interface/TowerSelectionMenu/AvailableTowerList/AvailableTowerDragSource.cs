﻿using TowerCreep.TowerCreep2D.Scripts.Interface.DragAndDrop;
using UnityEngine;

namespace TowerCreep.TowerCreep2D.Scripts.Interface.TowerSelectionMenu.AvailableTowerList
{
    public class AvailableTowerDragSource : DragAndDropSource
    {
        private AvailableTowerSlot towerSlot;

        private void Start()
        {
            towerSlot = GetComponent<AvailableTowerSlot>();
        }

        public override object GetDragAndDropData()
        {
            return new TowerSelectionPayload(towerSlot.GetTowerData());
        }

        public override Sprite GetDragAndDropSprite()
        {
            return towerSlot.GetSprite();
        }

        public override bool CanStartDragging()
        {
            return towerSlot.GetTowerData() != null && towerSlot.IsAvailable();
        }
    }
}