using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    private GameController gameController;
    [SerializeField] private TextMeshProUGUI timer;

    // Start is called before the first frame update
    void Start()
    {
        GameObject controller = GameObject.FindWithTag("GameController");
        gameController = controller.GetComponent<GameController>();
        timer = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = string.Format("Time Remaining: {0}:{1}", Mathf.Floor(Mathf.Round(gameController.getTime())/60), (Mathf.Round(gameController.getTime())%60).ToString("00"));
    }
}
