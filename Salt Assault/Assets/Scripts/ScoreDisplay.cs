using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    private GameController gameController;
    private TextMeshProUGUI scoreText;

    private void Awake()
    {
        GameObject gameControllerobj = GameObject.FindWithTag("GameController");
        gameController = gameControllerobj.GetComponent<GameController>();
        scoreText = this.GetComponent<TextMeshProUGUI>();
        scoreText.text = string.Format("Steaks Served: {0}", gameController.getScore());
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = string.Format("Steaks Served: {0}", gameController.getScore());
    }
}
