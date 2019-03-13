using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChefRating : MonoBehaviour
{
    private GameController gameController;
    private TextMeshProUGUI ratingText;

    private void Awake()
    {
        GameObject gameControllerobj = GameObject.FindWithTag("GameController");
        gameController = gameControllerobj.GetComponent<GameController>();
        ratingText = this.GetComponent<TextMeshProUGUI>();
        ratingText.text = string.Format("Chef Rating: {0} stars", gameController.getRating());
    }

}
