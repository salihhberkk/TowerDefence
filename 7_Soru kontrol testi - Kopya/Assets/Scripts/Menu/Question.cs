using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{

    public GameObject ui,pauseUI;
    public Text questionText ,answer1Text ,answer2Text,infoText;
    public Button answer1Button, answer2Button;
    public SceneFader sceneFader;
    List<QuestinsList> questions = new List<QuestinsList>();

     int random;
    void Start()
    {
        randomNumber();
        questions.Add(new QuestinsList("merhaba nasılsın", "sağol" , "kötü"));
        questions.Add(new QuestinsList("2+2", "4" , "5"));
        questions.Add(new QuestinsList("2*3", "5", "6"));     
    }
    private void Update()
    {
        questionText.text = questions[random].soru;
        answer1Text.text = questions[random].cevap1;
        answer2Text.text = questions[random].cevap2;
    }
    public void openUi()
    {
        infoText.text = "Soruyu Çözün";
        if (ui != null && !pauseUI.activeSelf){
            ui.SetActive(true);

            if (ui.activeSelf)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
    public void closeUi()
    {
        if (ui != null)
        {
            ui.SetActive(false);

            if (ui.activeSelf)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
    public void randomNumber()
    {
        random = Random.Range(0, 3);
    }
    public void selectButton1()
    {
        answer2Button.interactable = false;
        answer1Button.interactable = false;
        Debug.Log("1.ci buton seçildi");
        if (random == 0)
        {
            infoText.text = "doğru cevap";
            PlayerStats.Money += 50;
            return;
        }
        if (random == 1)
        {
            infoText.text = "doğru cevap";
            PlayerStats.Money += 50;
            return;
        }
        if (random == 2)
        {
            infoText.text = "yanlış cevap";
            return;
        }
    }
    public void selectButton2()
    {
        answer2Button.interactable = false;
        answer1Button.interactable = false;
        Debug.Log("2.ci buton seçildi");
        if (random == 0)
        {
            infoText.text = "yanlış cevap";
            return;
        }
        if (random == 1)
        {
            infoText.text = "yanlış cevap";
            return;
        }
        if (random == 2)
        {
            infoText.text = "doğru cevap";
            PlayerStats.Money += 50;
            return;
        }

    }
    public void Select()
    {
        answer2Button.interactable = true;
        answer1Button.interactable = true;
    }

}




