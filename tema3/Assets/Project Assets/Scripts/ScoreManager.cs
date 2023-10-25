using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;
    
    private int score = 0;

    public void AddScore(int value)
    {
        score += value;
        scoreDisplay.SetText(score + " points");
    }
}
