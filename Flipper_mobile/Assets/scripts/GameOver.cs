using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public TMP_Text scoreText;
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = "Score : " + score.ToString();
    }

    public void redirect_Restart()
    {
        Debug.Log("restart");
        SceneManager.LoadScene("SampleScene");
    }

    public void redirect_Menu()
    {
        Debug.Log("menu");
        SceneManager.LoadScene("Menu");
    }

}
