﻿using System.Collections;
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
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = string.Format("Score: {0}", gameController.getScore());
    }
}