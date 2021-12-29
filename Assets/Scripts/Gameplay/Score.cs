using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

	public static int score;
	public static int highscore;

	void Start()
	{
		score = 0;
		highscore = 0;
	}

	void Update()
	{
		score = Difficulty.totalPlaytime;
		highscore = PlayerPrefs.GetInt("highscore", 0);

		if(highscore < score)
        {
			PlayerPrefs.SetInt("highscore", score);
        }
	}

	void OnGUI()
	{
		GetComponent<UnityEngine.UI.Text>().text = score.ToString();
	}
}