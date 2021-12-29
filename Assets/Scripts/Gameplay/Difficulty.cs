using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty: MonoBehaviour
{

    public static float gameSpeed = 1f;
    public float defGameSpeed = 1f;
    public float dificultyRatio = 0.01f;
    public int dificultyMultiple = 50;

    public static int totalPlaytime = 0;
    private float timer;

    void Start()
    {
        gameSpeed = defGameSpeed;
        totalPlaytime = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        bool isTimerReachedOneSec = timer > 1f;
        if (isTimerReachedOneSec)
        {
            UpdateTotalPlaytime();
        }
    }

    private void UpdateTotalPlaytime()
    {
        totalPlaytime++;
        timer = 0f;
        IncreaseGameSpeed();
    }

    private void IncreaseGameSpeed()
    {
        bool hasReachedNewLevel = totalPlaytime % dificultyMultiple == 0;
        if (hasReachedNewLevel)
        {
            gameSpeed += gameSpeed * dificultyRatio;
        }
    }
}