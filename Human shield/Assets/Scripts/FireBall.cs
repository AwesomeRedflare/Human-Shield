using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{

    public float speed;
    public GameObject impactEffect;

    private void Start()
    {
        // transform.Rotate(Vector3.forward, Random.Range(0f, 360f));
        Destroy(gameObject, 10);
    }

    private void Update()
    {
        transform.position += transform.up * (speed + FireBallSpawner.difficulty) * Time.deltaTime;
    }

    private void OnTriggerEnter2D (Collider2D pow)
    {
        if (pow.gameObject.tag == "Lilly")
        {
            Instantiate(impactEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (pow.gameObject.tag == "Player")
        {
            Instantiate(impactEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
