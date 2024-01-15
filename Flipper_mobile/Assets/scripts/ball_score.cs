using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ball_score : MonoBehaviour
{
    public int score = 0;

    public TMP_Text compteur;

    private int[] tag_score = { 5, 10, 20, 30, 40, 50, 60, 70, 80, 150 };

    private void Start()
    {
 
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("ball end"))
        {
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (int tagScore in tag_score)
        {
            if (collision.gameObject.CompareTag(tagScore.ToString()))
            {
                UpdateScoreText(tagScore);
                break;
            }
        }
    }

    void UpdateScoreText(int a)
    {
        score += a;
        compteur.text = "Score : " + score.ToString();
    }
}
