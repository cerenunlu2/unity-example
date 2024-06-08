using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.EditorUtilities;

public class Score : MonoBehaviour
{
    int score;
    TMP_Text scoreText; 
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "0";
    }
    public void IncreaseScore(int increaseAmount)
    {
        score += increaseAmount;
        scoreText.text = score.ToString();
    }
   
}
