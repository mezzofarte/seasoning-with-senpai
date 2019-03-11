using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
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

    private void Awake()
    {
        player = GetComponent<Rigidbody>();
        playerPosition = this.transform.position;
        particles = this.GetComponentInChildren<ParticleSystem>();
    }

    void Start()
    {
        particles.Pause();
        healthText.text = "HP: " + health.ToString();
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
            health -= 2f;
        }
        gameOver();
        updateHealth();
    }

    public void takeDamage()
    {
        particles.Play();
        isSeason = true;
        seasonDuration = 0;
        health -= .1f;
        
    }
    public void gameOver()
    {
        if (health<= 0)
        {
            onPlayerDeath.Invoke();
        }
    }


    private void updateHealth()
    {
        if (health < 0) health = 0;
        healthText.text = "HP: " + health.ToString("0");
        float ratio = health / 100;
        healthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }
}   
