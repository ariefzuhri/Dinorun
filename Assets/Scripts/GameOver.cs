using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private Text score;
    private Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        highScore = GameObject.Find("Hasil High").GetComponent<Text>();
        score = GameObject.Find("Hasil Score").GetComponent<Text>();
        score.text = Score.score.ToString();
        highScore.text = Score.highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //if (score.score > playerprefs.getint("highscore", 0))
        //{
        //    playerprefs.setint("highscore", score.score);
        //    highscore.text = score.score.tostring();
        //}
        //else
        //{
        //    highscore.text = score.score.tostring();
        //}
    }
}
