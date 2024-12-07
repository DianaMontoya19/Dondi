using Script;
using System.Collections;
using System.Collections.Generic;
using Script.Buscaminas;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject gameOver;

    void Start()
    {
        if (gameOver != null)
        {
            gameOver.SetActive(false);
        }
    }

    // Update is called once per frame
    public void Update()
    {
        LoseCondition(Generator.instance.lose);
    }
    public void LoseCondition(bool lose)
    {
        if (lose)
        {
            gameOver.SetActive(true);

        }
        GameManager.Instance.GameOver();
    }
}
