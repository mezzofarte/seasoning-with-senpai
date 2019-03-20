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
    public Material material;
    public TextMeshProUGUI healthText;
    public Image healthBar;

    private Vector3 playerPosition;
    private bool isSeason = false;
    private float seasonDuration = 0f;
    //private ParticleSystem particles;
    public GameObject steak;

    private void Awake()
    {
        player = GetComponent<Rigidbody>();
        playerPosition = this.transform.position;
    }

    void Start()
    {
        healthText = GameObject.FindWithTag("HealthObject").GetComponent<TextMeshProUGUI>();
        healthBar = GameObject.FindWithTag("HealthBar").GetComponent<Image>();
        // I commented this out because it kept giving an error: "NullReferenceException: Object reference not set to an instance of an object"
        // particles.Pause();
        healthText.text = "Season: " + seasoningScore.ToString() + "%";
        material = Resources.Load("Meat red", typeof(Material)) as Material;
        material.color = Color.red;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            player.mass = .5f;
        }
        else
        {
            player.mass = 1;
        }

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
/*            particles.Pause();
            particles.Clear();*/
        }
        playerPosition = this.transform.position;
        if (this.transform.position.y < -10f)
        {
            GameObject gameControllerobj = GameObject.FindWithTag("GameController");
            gameControllerobj.GetComponent<GameController>().newSteak();
            gameControllerobj.GetComponent<GameController>().increaseFailed();
            Destroy(this);
        }
        if (seasoningScore >= 130f)
        {
            material.color = new Color(0f, 0f, 0f, 0f);
        }
        else if (seasoningScore >= 100f)
        {
            material.color = new Color(0.392f, 0.165f, 0.106f, 0.0f);
        }
        else if (seasoningScore >= 50f)
        {
            material.color = new Color(0.580f, 0.114f, 0.106f, 0.0f);
        }
        updateSeasoningScore();
        serveSteak();
    }

    public void season()
    {
        seasoningScore += 3f;
        
    }
    
    public void serveSteak()
    {
        if (seasoningScore >= 130 && Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gameControllerobj = GameObject.FindWithTag("GameController");
            gameControllerobj.GetComponent<GameController>().newSteak();
            gameControllerobj.GetComponent<GameController>().increaseFailed();
            Destroy(steak);
        }
        else if (seasoningScore >= 100 && Input.GetKeyDown(KeyCode.Space))
        {
            GameObject gameControllerobj = GameObject.FindWithTag("GameController");
            gameControllerobj.GetComponent<GameController>().newSteak();
            gameControllerobj.GetComponent<GameController>().increaseScore();
            Destroy(steak);
            
        }
    }
    

    private void updateSeasoningScore()
    {
        if (seasoningScore < 0) seasoningScore = 0;
        if (seasoningScore > 150) seasoningScore = 150;
        healthText.text = "Season: " + seasoningScore.ToString("0") + "%";
        if (seasoningScore <= 100)
        {
            float ratio = seasoningScore / 100;
            healthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        }
    }
}   
