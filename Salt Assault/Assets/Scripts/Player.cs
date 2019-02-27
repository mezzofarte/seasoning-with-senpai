using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 25f;
    private Rigidbody player;
    public float health = 100f;
    public TextMeshProUGUI healthText;

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
            healthText.text = "HP: " + health.ToString();
        }
    }

    public void takeDamage()
    {
        health -= .1f;
        healthText.text = "HP: " + health.ToString();
    }
}
