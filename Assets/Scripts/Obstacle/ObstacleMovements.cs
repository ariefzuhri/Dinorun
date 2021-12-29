using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleMovements : MonoBehaviour
{

    public bool isBossEnemy = false;

    public float speed = 6.0f;
    public float defSpeed = 6.0f;
    private float gameSpeed;

    private bool hasHitted = false;

    void Start()
    {
        gameSpeed = Difficulty.gameSpeed;
        hasHitted = false;
        SetInitialSpeedAccordGameSpeed();
    }

    private void SetInitialSpeedAccordGameSpeed()
    {
        speed = defSpeed * gameSpeed;
    }

    void Update()
    {
        CheckGameSpeed();
        ScrollObstacle();
    }

    private void ScrollObstacle()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }


    private void CheckGameSpeed()
    {
        if (isBossEnemy) return;
        float currentGameSpeed = Difficulty.gameSpeed;
        bool isCurrentGameSpeedChanged = currentGameSpeed != gameSpeed;
        if (isCurrentGameSpeedChanged)
        {
            gameSpeed = currentGameSpeed;
            IncreaseSpeed();
        }
    }

    private void IncreaseSpeed()
    {
        speed *= gameSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player" && !hasHitted)
        {
            hasHitted = true;

            if (Health.healthCount > 0)
            {
                Health.healthCount--;
            }

            if (Health.healthCount == 0)
            {
                PlayerPrefs.SetInt("CurrentScore", Score.score);
                SceneManager.LoadScene("GameOver");
            }
        }

        if (collision.collider.tag == "Player" || collision.collider.tag == "Obstacle")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}