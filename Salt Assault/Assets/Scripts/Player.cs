using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 25f;
    private Rigidbody player;
    public float health = 100f;
    public TextMeshProUGUI healthText;
    public Image healthBar;

    void Start()
    {
        player = GetComponent<Rigidbody>();
        healthText.text = "HP: " + health.ToString();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        player.AddForce(movement * speed);

        Debug.Log(this.transform.position.y);

        if (this.transform.position.y < -10f)
        {
            health -= 2f;
            if (health < 0) health = 0;
            healthText.text = "HP: " + health.ToString("0");
            float ratio = health / 100;
            healthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        }
        gameOver();
    }

    public void takeDamage()
    {
        health -= .1f;
        if (health < 0) health = 0;
        healthText.text = "HP: " + health.ToString("0");
        float ratio = health / 100;
        healthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    }
    public void gameOver()
    {
        if (health<= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}   
