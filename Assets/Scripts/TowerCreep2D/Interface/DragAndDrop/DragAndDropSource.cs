﻿using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TowerCreep2D.Interface.DragAndDrop
{
    public abstract class DragAndDropSource : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public static Action<DragAndDropSource> OnDnDSourceMouseEnter;
        public static Action<DragAndDropSource> OnDnDSourceMouseExit;

        public void OnPointerEnter(PointerEventData eventData)
        {
            OnDnDSourceMouseEnter?.Invoke(this);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            OnDnDSourceMouseExit?.Invoke(this);
        }

        public virtual bool CanStartDragging()
        {
            return true;
        }

        public abstract object GetDragAndDropData();
        public abstract Sprite GetDragAndDropSprite();
    }
}