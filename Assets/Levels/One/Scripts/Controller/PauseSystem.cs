using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseSystem : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject gameOverPanel;
    public LifeSystem LS;
    public TextMeshProUGUI game_over_text;

    void Start()
    {
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    void Update()
    {
        PauseScreen();
        GameOverScreen();
    }

    public void PauseScreen()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pausePanel.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pausePanel.SetActive(false);
            }
        }
    }

    public void QuitMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ReloadLevelFunction()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void GameOverScreen()
    {
        if(LS.life == 0)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            game_over_text.text = "Você fez " + PointsSystem.instance.points_number + " pontos!";
        }
    }
}
