using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameOver : MonoBehaviour
{
    public TMP_Text scoreText;
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = "Score : " + score.ToString();
    }

    void Update()
    {
        
    }
}
