using TowerCreep2D.TowerCreep2D.Scripts.Utility;
using UnityEngine;

namespace TowerCreep2D.TowerCreep2D.Scripts.Interface.WinScreen
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