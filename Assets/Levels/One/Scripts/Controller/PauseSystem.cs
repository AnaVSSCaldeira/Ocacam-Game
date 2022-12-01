using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseSystem : MonoBehaviour
{
    public GameObject pause_panel;
    public GameObject game_over_panel;
    public GameObject win_game_panel;
    public LifeSystem LS;
    public TimerSystem TS;
    public TextMeshProUGUI game_over_text;
    public TextMeshProUGUI win_game_text;
    public TextMeshProUGUI timer_text;

    void Start()
    {
        game_over_panel.SetActive(false);
        Time.timeScale = 1;
        pause_panel.SetActive(false);
    }

    void Update()
    {
        PauseScreen();
        GameOverScreen();
        WinGame();
    }

    public void PauseScreen()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pause_panel.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pause_panel.SetActive(false);
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
            timer_text.text = "Você sobreviveu por ";
            if(TS.minute < 1)
            {
                timer_text.text = timer_text.text + TS.second + " segundo(s)";
            }
            else
            {
                timer_text.text = timer_text.text + TS.minute + " minuto(s) e " + TS.second + " segundo(s)";
            }
            Time.timeScale = 0;
            game_over_panel.SetActive(true);
            game_over_text.text = "Você fez " + PointsSystem.instance.points_number + " pontos!";
        }
    }
    public void WinGame()
    {
        if(LS.life > 0 && TS.minute == 5f)
        {
            Time.timeScale = 0;
            win_game_panel.SetActive(true);
            win_game_text.text = "Parabéns! Você completou o jogo! Você fez " + PointsSystem.instance.points_number + " pontos!";
        }
    }
}
