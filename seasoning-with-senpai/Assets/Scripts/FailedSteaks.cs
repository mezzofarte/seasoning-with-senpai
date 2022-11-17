using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FailedSteaks : MonoBehaviour
{
    private GameController gameController;
    private TextMeshProUGUI failedText;

    private void Awake()
    {
        GameObject gameControllerobj = GameObject.FindWithTag("GameController");
        gameController = gameControllerobj.GetComponent<GameController>();
        failedText = this.GetComponent<TextMeshProUGUI>();
        failedText.text = string.Format("Steaks Failed: {0}", gameController.getFailed());
    }

    // Update is called once per frame
    void Update()
    {
        failedText.text = string.Format("Steaks Failed: {0}", gameController.getFailed());
    }
}
