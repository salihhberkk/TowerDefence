using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestinsList : MonoBehaviour
{
    public string soru,cevap1 ,cevap2;

    public QuestinsList(string yeniSoru , string yeniCevap1 , string yeniCevap2)
    {
        soru = yeniSoru;
        cevap1 = yeniCevap1;
        cevap2 = yeniCevap2;

    }

    
}
