using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GameOver()
    {
        PlayerPrefs.GetInt("CurrentScore");
        SceneManager.LoadScene("GameOver");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitMenu() {
        Application.Quit();
    }

    public void CreditMenu()
    {
        SceneManager.LoadScene("CreditMenu");
    }
}