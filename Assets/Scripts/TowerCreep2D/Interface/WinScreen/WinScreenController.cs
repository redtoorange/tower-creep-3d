using TowerCreep2D.Utility;
using UnityEngine;

namespace TowerCreep2D.Interface.WinScreen
{
    public class WinScreenController : MonoBehaviour
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