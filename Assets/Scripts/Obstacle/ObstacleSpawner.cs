using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public float minTime = 1.5f;
    public float maxTime = 6.0f;
    private float timer;
    private float spawnTime;

    public GameObject[] obstacles;

    void Start()
    {
        timer = 0f;
        spawnTime = Random.Range(minTime, maxTime);
    }

    void Update()
    {
        if (timer > spawnTime)
        {
            int randomIndex = Random.Range(0, obstacles.Length);
            GameObject newObstacle = Instantiate(obstacles[randomIndex]);
            newObstacle.transform.position = transform.position + new Vector3(0, 0, 0);
            Destroy(newObstacle, 15);

            timer = 0f;
            spawnTime = Random.Range(minTime, maxTime);
        }

        timer += Time.deltaTime;
    }
}