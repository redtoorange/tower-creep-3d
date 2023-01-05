using TowerCreep2D.Utility;
using UnityEngine;

namespace TowerCreep2D.Interface.LoseScreen
{
    public class LoseScreenController : MonoBehaviour
    {
        public void OnMainMenuPressed()
        {
            GameManager.S.ChangeToMainMenu();
        }

        public void OnPlayAgainPressed()
        {
            GameManager.S.ChangeToGame();
        }
    }
}