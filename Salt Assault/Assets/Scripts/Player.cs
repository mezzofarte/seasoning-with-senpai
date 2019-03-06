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
    private float stayStill = 0f;

    private void Awake()
    {
        player = GetComponent<Rigidbody>();
        playerPosition = this.transform.position;
    }

    void Start()
    {
        healthText.text = "HP: " + health.ToString();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        player.AddForce(movement * speed);

        //Debug.Log(this.transform.position.y);

        if (playerPosition == this.transform.position)
        {
            stayStill += Time.deltaTime;
        }
        else
        {
            stayStill = 0;
        }
        playerPosition = this.transform.position;
        if (this.transform.position.y < -10f)
        {
            health -= 2f;
        }
        gameOver();
        burning();
        updateHealth();
    }

    public void takeDamage()
    {
        health -= .1f;
        
    }
    public void gameOver()
    {
        if (health<= 0)
        {
            onPlayerDeath.Invoke();
        }
    }

    public void burning()
    {
        if (stayStill>=3)
        {
            health -= .03f;
            Debug.Log(stayStill);
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
