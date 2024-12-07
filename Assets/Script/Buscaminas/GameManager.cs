using UnityEngine;

namespace Script.Buscaminas
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        private int totalReward = 0;

        private void Awake()
        {
            if (Instance == null) Instance = this;
        }

        public void AddReward(int reward)
        {
            totalReward += reward;
            UIManager.Instance.UpdateReward(totalReward);
        }

        public void GameOver()
        {
            UIManager.Instance.ShowGameOver();
            Debug.Log("Game Over!");
        }
    }
}