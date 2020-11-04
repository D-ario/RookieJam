using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TEAM7_score : MonoBehaviour
{
    public static TEAM7_score instance;
    public Text text;
    int team7_score = 100;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        text.text = "Points: 100";
    }

    public void ChangeScore(int scoreValue, bool isAugmented)
    {
        if (isAugmented == true)
        {
            team7_score += scoreValue;
        }
        if (isAugmented == false)
        {
            team7_score -= scoreValue;
        }
        
        text.text = "Points: " + team7_score.ToString();
    }
}
