using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject ui,questionUI;

    public string menuSceneName = "MainMenu";

    public SceneFader sceneFader;
    void Update()
    {
        if (GameManager.GameIsOver)
        {
            return;
        }
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P) && !questionUI.activeSelf)
        {
            Toggle();
        }
    }
    public void Toggle()
    {
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    public void Retry()
    {
        WaveSpawner.EnemiesAlive = 0;
        Toggle();
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
        
    }
    public void Menu()
    {
        // Debug.Log("menüye git");
        Toggle();
        sceneFader.FadeTo(menuSceneName);
    }
}
