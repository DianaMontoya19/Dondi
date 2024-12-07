using UnityEngine;
using UnityEngine.UI;

namespace Script.Buscaminas
{

    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance;

        [Header("UI Elements")]
        [SerializeField] private Text rewardText;
        [SerializeField] private GameObject gameOverPanel;
        [SerializeField] private Text gameOverMessage;

        private void Awake()
        {
            if (Instance == null) Instance = this;
        }

        public void UpdateReward(int totalReward)
        {
            rewardText.text = "Reward: $" + totalReward;
        }

        public void ShowGameOver()
        {
            gameOverPanel.SetActive(true);
            gameOverMessage.text = "Game Over! Better luck next time!";
        }

        public void HideGameOver()
        {
            gameOverPanel.SetActive(false);
        }
    }
}