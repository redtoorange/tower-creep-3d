using UnityEngine;

namespace TowerCreep2D.TowerCreep2D.Scripts.Player
{
    public enum PlayerMovementState
    {
        Moving,
        Idle
    }

    public enum PlayerMovementDirection
    {
        Front,
        Back,
        Left,
        Right
    }

    public class PlayerSprite : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer animatedSprite;
        private PlayerMovementState movementState = PlayerMovementState.Idle;
        private PlayerMovementDirection movementDirection = PlayerMovementDirection.Front;

        public void UpdateAnimation(Vector2 actualMovement)
        {
            bool animationDirty = false;
            PlayerMovementState newMovementState = movementState;
            if (actualMovement.sqrMagnitude > 0)
            {
                newMovementState = PlayerMovementState.Moving;
            }
            else
            {
                newMovementState = PlayerMovementState.Idle;
            }

            if (newMovementState != movementState)
            {
                movementState = newMovementState;
                animationDirty = true;
            }

            PlayerMovementDirection newMovementDirection = movementDirection;
            if (Mathf.Abs(actualMovement.x) > Mathf.Abs(actualMovement.y))
            {
                if (actualMovement.x > 0)
                {
                    newMovementDirection = PlayerMovementDirection.Right;
                }
                else if (actualMovement.x < 0)
                {
                    newMovementDirection = PlayerMovementDirection.Left;
                }
            }
            else if (Mathf.Abs(actualMovement.x) < Mathf.Abs(actualMovement.y))
            {
                if (actualMovement.y < 0)
                {
                    newMovementDirection = PlayerMovementDirection.Back;
                }
                else if (actualMovement.y > 0)
                {
                    newMovementDirection = PlayerMovementDirection.Front;
                }
            }

            if (newMovementDirection != movementDirection)
            {
                movementDirection = newMovementDirection;
                animationDirty = true;
            }


            if (animationDirty)
            {
                ChangeAnimation();
            }
        }

        private void ChangeAnimation()
        {
            string movementString = (movementState == PlayerMovementState.Idle ? "idle" : "walk") + "_";
            animatedSprite.flipX = false;

            if (movementDirection == PlayerMovementDirection.Front)
            {
                movementString += "front";
            }
            else if (movementDirection == PlayerMovementDirection.Back)
            {
                movementString += "back";
            }
            else if (movementDirection == PlayerMovementDirection.Right)
            {
                movementString += "side";
            }
            else if (movementDirection == PlayerMovementDirection.Left)
            {
                movementString += "side";
                animatedSprite.flipX = true;
            }

            // animatedSprite.Animation = movementString;
        }
    }
}