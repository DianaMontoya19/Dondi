using UnityEngine;
using UnityEngine.UI;

namespace Script.Buscaminas
{
    public class Cell : MonoBehaviour
    {
        public Button button;
        public Text cellText;
        public bool isMine = false;
        private int x, y;

        public void Init(int x, int y)
        {
            this.x = x;
            this.y = y;
            button.onClick.AddListener(OnCellClicked);
        }

        public void SetMine()
        {
            isMine = true;
        }

        private void OnCellClicked()
        {
            if (isMine)
            {
                cellText.text = "💣";
                GameManager.Instance.GameOver();
            }
            else
            {
                int reward = Random.Range(1, 5); // Multiplicador aleatorio
                cellText.text = reward.ToString();
                GameManager.Instance.AddReward(reward);
            }

            button.interactable = false;
        }
    }
}