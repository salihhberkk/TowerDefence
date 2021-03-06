using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;

     void Start()
    {
        for (int i = 0; i < levelButtons.Length; i++)
        {
            int levelReached = PlayerPrefs.GetInt("levelReached", 1);

            if (i + 1  > levelReached)
            {
                levelButtons[i].interactable = false;
            }    
        }
    }

    public Button[] levelButtons;
    public void Select(string levelname)
    {
        fader.FadeTo(levelname);
    }
}
