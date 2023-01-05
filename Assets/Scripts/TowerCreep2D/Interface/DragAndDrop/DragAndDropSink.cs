﻿using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TowerCreep2D.Interface.DragAndDrop
{
    public abstract class DragAndDropSink : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public static Action<DragAndDropSink> OnDnDSinkMouseEnter;
        public static Action<DragAndDropSink> OnDnDSinkMouseExit;

        public void OnPointerEnter(PointerEventData eventData)
        {
            OnDnDSinkMouseEnter?.Invoke(this);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            OnDnDSinkMouseExit?.Invoke(this);
        }

        public abstract bool CanDropData(object data);
        public abstract void DropData(object data);
    }
}