using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSpawner : MonoBehaviour
{

    public GameObject fireBall;

    public static float difficulty = 0f;
    private float maxDifficulty = 10f;

    private float lTimeBtwSpawn = 1;
    public float lStartTimeBtwSpawn;
    private float rTimeBtwSpawn = 2.5f;
    public float rStartTimeBtwSpawn;
    private float bTimeBtwSpawn = 5;
    public float bStartTimeBtwSpawn;
    private float tTimeBtwSpawn = 2.5f;
    public float tStartTimeBtwSpawn;

    private void Start()
    {
        difficulty = 0f;
    }

    private void Update()
    {
        if (lTimeBtwSpawn <= 0)
        {
            lStartTimeBtwSpawn = Random.Range(2f, 7f);
            lTimeBtwSpawn = lStartTimeBtwSpawn;
            LeftSpawnFireBall();
            if (difficulty < maxDifficulty)
            {
                difficulty += .005f;
            }
        } else
        {
            lTimeBtwSpawn -= Time.deltaTime;
        }

        if (rTimeBtwSpawn <= 0)
        {
            rStartTimeBtwSpawn = Random.Range(2f, 7f);
            rTimeBtwSpawn = rStartTimeBtwSpawn;
            RightSpawnFireBall();
            if (difficulty < maxDifficulty)
            {
                difficulty += .005f;
            }
        }
        else
        {
            rTimeBtwSpawn -= Time.deltaTime;
        }

        if (bTimeBtwSpawn <= 0)
        {
            bStartTimeBtwSpawn = Random.Range(2f, 7f);
            bTimeBtwSpawn = bStartTimeBtwSpawn;
            BottomSpawnFireBall();
            if (difficulty < maxDifficulty)
            {
                difficulty += .005f;
            }
        }
        else
        {
            bTimeBtwSpawn -= Time.deltaTime;
        }

        if (tTimeBtwSpawn <= 0)
        {
            TopSpawnFireBall();
            tStartTimeBtwSpawn = Random.Range(2f, 7f);
            tTimeBtwSpawn = tStartTimeBtwSpawn;
            if (difficulty < maxDifficulty)
            {
                difficulty += .005f;
            }
        }
        else
        {
            tTimeBtwSpawn -= Time.deltaTime;
        }
    }

    void LeftSpawnFireBall()
    {

        if (tag == "Left Spawner")
        {
            transform.Rotate(Vector3.forward, Random.Range(-170f, -20f));
         
            Instantiate(fireBall, transform.position, transform.rotation);

            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

    }

    void RightSpawnFireBall()
    {
        if (tag == "Right Spawner")
        {
            transform.Rotate(Vector3.forward, Random.Range(20f, 130f));

            Instantiate(fireBall, transform.position, transform.rotation);

            transform.rotation = Quaternion.Euler(0, 0, 45);
        }

    }

    void BottomSpawnFireBall()
    {
        if (tag == "Bottom Spawner")
        {
            transform.Rotate(Vector3.forward, Random.Range(-75f, 75f));

            Instantiate(fireBall, transform.position, transform.rotation);

            transform.rotation = Quaternion.Euler(0, 0, 45);
        }
    }

    void TopSpawnFireBall()
    {
        if (tag == "Top Spawner")
        {
            transform.Rotate(Vector3.forward, Random.Range(-250f, -110f));

            Instantiate(fireBall, transform.position, transform.rotation);

            transform.rotation = Quaternion.Euler(0, 0, 45);
        }
    }
}
