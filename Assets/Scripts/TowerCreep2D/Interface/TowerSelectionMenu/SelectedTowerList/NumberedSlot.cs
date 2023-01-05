﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TowerCreep2D.Interface.TowerSelectionMenu.SelectedTowerList
{
    public class NumberedSlot : MonoBehaviour
    {
        [SerializeField] private Image numberDisplay;
        [SerializeField] private List<Sprite> numberImages;

        private int slotNumber = 0;

        public void SetNumber(int number)
        {
            slotNumber = number;

            if (slotNumber < numberImages.Count)
            {
                numberDisplay.sprite = numberImages[slotNumber];
            }
        }
    }
}