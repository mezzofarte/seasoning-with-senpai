using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private float score = 0;
    private int health = 3;

    // Update is called once per frame
    void Update()
    {
        score += (Time.deltaTime * 4);
    }

    public int getScore()
    {
        return (int)score;
    }

    public int getHealth()
    {
        return health;
    }
}
