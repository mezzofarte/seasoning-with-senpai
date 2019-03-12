﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject steakPrefab;
    private int score = 0;
    public bool gameOver = false;
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject gameOverPanel;
    public Camera camera;
    public GameObject wallLeft;
    public GameObject wallRight;
    public GameObject wallUp;
    public GameObject wallDown;

    void Awake()
    {
        playerObject.GetComponent<Player>().onPlayerDeath.AddListener(setGameOverPanelActive);
    }

    void Start()
    {
        Instantiate(wallLeft, camera.ScreenToWorldPoint(new Vector3(0,0,Screen.height / 2)), Quaternion.identity);
        Instantiate(wallRight, camera.ScreenToWorldPoint(new Vector3(Screen.width,0,Screen.height / 2)), Quaternion.identity);
        Instantiate(wallUp, camera.ScreenToWorldPoint(new Vector3(Screen.width/2,0,Screen.height / 2)), Quaternion.identity);
        Instantiate(wallDown, camera.ScreenToWorldPoint(new Vector3(Screen.width/2,0,Screen.height)), Quaternion.identity);
    }

    void Update()
    {
    }

    public int getScore()
    {
        return score;
    }

    public void increaseScore()
    {
        score++;
    }
    

    void setGameOverPanelActive()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
    }
    public void newSteak()
    {
        var rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(-90f, 0f, -40.938f);
        Instantiate(steakPrefab, new Vector3(26.2f, -6.9f, 46.9f), rotation);
    }
}
