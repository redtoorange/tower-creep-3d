using TowerCreep2D.TowerCreep2D.Scripts.Utility;
using UnityEngine;

namespace TowerCreep2D.TowerCreep2D.Scripts.Interface.LoseScreen
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