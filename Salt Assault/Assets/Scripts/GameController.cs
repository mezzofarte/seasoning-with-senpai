using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject steakPrefab;
    private int score = 0;
    private int failed = 0;
    public bool gameOver = false;
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject gameOverPanel;
    public Camera camera;
    public GameObject wallLeft;
    public GameObject wallRight;
    public GameObject wallUp;
    public GameObject wallDown;
    public float timeStart = 180f;

    void Awake()
    {

    }

    void Start()
    {
        Time.timeScale = 1;

        Instantiate(wallLeft, camera.ScreenToWorldPoint(new Vector3(0, Screen.height / 2, 0)), camera.transform.rotation);
        Instantiate(wallRight, camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 2, 0)), camera.transform.rotation);

        Instantiate(wallUp, camera.ScreenToWorldPoint(new Vector3(Screen.width / 2, 0, 0)), camera.transform.rotation);
        Instantiate(wallDown, camera.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height, 0)), camera.transform.rotation);
    }

    void Update()
    {
        if (!gameOver)
        {
            timeStart -= Time.deltaTime;
        }

        if (timeStart <= 0)
        {
            setGameOverPanelActive();
        }
    }

    public int getScore()
    {
        return score;
    }

    public float getTime()
    {
        return timeStart;
    }

    public float getFailed()
    {
        return failed;
    }

    public float getRating()
    {
        return (score * 0.5f) - (failed * 1f);
    }

    public void increaseScore()
    {
        score++;
    }

    public void increaseFailed()
    {
        failed++;
    }

    void setGameOverPanelActive()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void newSteak()
    {
        var rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(-90f, 0f, -40.938f);
        Instantiate(steakPrefab, new Vector3(26.2f, -6.9f, 46.9f), rotation);
    }
}