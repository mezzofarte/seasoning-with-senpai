using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HealthDisplay : MonoBehaviour
{
    private GameController gameController;
    private TextMeshProUGUI healthText;

    private void Awake()
    {
        GameObject gameControllerobj = GameObject.FindWithTag("GameController");
        gameController = gameControllerobj.GetComponent<GameController>();
        healthText = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //healthText.text = string.Format("Health: {0}", gameController.getHealth());
    }
}
