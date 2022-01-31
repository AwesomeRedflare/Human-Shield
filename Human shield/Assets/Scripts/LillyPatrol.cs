using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LillyPatrol : MonoBehaviour
{

    public Text healthDisplay;

    public float speed;
    private float waitTime;
    public float startWaitTime;

    public int health = 3;

    public Transform moveSpot;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public GameObject gameOverPanel;
    public GameObject jimmy;
    

    private void Start()
    {
        waitTime = startWaitTime;

        moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpot.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                speed = Random.Range(2f, 3f);
                startWaitTime = Random.Range(0f, 5f);
                waitTime = startWaitTime;
                moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }

        healthDisplay.text = "Lilly's health: " + health.ToString();

        if (health == 0)
        {
            Destroy(gameObject);
            Destroy(jimmy);
            gameOverPanel.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D damage)
    {
        health -= 1;
    }
}