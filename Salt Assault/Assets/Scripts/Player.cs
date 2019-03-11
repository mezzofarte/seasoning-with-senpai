using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public float seasoningScore = 0f;
    public float speed = 25f;
    private Rigidbody player;
    public float health = 100f;
    public TextMeshProUGUI healthText;
    public Image healthBar;
    public UnityEvent onPlayerDeath;

    private Vector3 playerPosition;
    private bool isSeason = false;
    private float seasonDuration = 0f;
    private ParticleSystem particles;
    public GameObject steak;

    private void Awake()
    {
        player = GetComponent<Rigidbody>();
        playerPosition = this.transform.position;
        particles = this.GetComponentInChildren<ParticleSystem>();
    }

    void Start()
    {
        healthText = GameObject.FindWithTag("HealthObject").GetComponent<TextMeshProUGUI>();
        healthBar = GameObject.FindWithTag("HealthBar").GetComponent<Image>();
        //particles.Pause();
        healthText.text = "Season: " + seasoningScore.ToString() + "%";
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        player.AddForce(movement * speed);

        //Debug.Log(this.transform.position.y);

        if (isSeason && seasonDuration< 2)
        {
            seasonDuration += Time.deltaTime;
        }
        if (isSeason && seasonDuration > 2)
        {
            isSeason = false;
            particles.Pause();
            particles.Clear();
        }
        playerPosition = this.transform.position;
        if (this.transform.position.y < -10f)
        {
            GameObject gameControllerobj = GameObject.FindWithTag("GameController");
            gameControllerobj.GetComponent<GameController>().newSteak();
            
            Destroy(this);
        }
        updateSeasoningScore();
        serveSteak();
    }

    public void season()
    {
        seasoningScore += 1f;
        
    }
    
    public void serveSteak()
    {
        if (seasoningScore == 100 && Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gameControllerobj = GameObject.FindWithTag("GameController");
            gameControllerobj.GetComponent<GameController>().newSteak();
            Destroy(steak);
            
        }
    }
    

    private void updateSeasoningScore()
    {
        if (seasoningScore < 0) seasoningScore = 0;
        if (seasoningScore > 100) seasoningScore = 100;
        healthText.text = "Season: " + seasoningScore.ToString("0") + "%";
        float ratio = seasoningScore / 100;
        healthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }
}   
