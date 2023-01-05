﻿using System;
using TowerCreep2D.Levels;
using UnityEngine;

namespace TowerCreep2D.Interface.BuildPhase
{
    public class BuildPhaseController : MonoBehaviour
    {
        public static Action OnBuildPhaseComplete;
        [SerializeField] private GameObject buttonContainer;

        private void Start()
        {
            LevelManager.OnNewLevelLoaded += EnableButton;
        }

        private void OnDestroy()
        {
            LevelManager.OnNewLevelLoaded -= EnableButton;
        }

        private void EnableButton()
        {
            buttonContainer.SetActive(true);
        }


        public void OnBuildPhaseCompletePressed()
        {
            OnBuildPhaseComplete?.Invoke();
            buttonContainer.SetActive(false);
        }
    }
}