using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ball_score : MonoBehaviour
{
    public int score = 10;

    public GameObject test;
    public TMP_Text compteur;

    private int[] tag_score = { 5, 10, 20, 30, 40, 50, 60, 70, 80, 150 };

    private GameObject gameManager;


    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gamemanager");
        test = GameObject.FindGameObjectWithTag("Score");
        compteur = test.GetComponent<TextMeshPro>();
        
        compteur.text = "Score : " + score.ToString();
        Debug.Log("test");
    }



    void OnTriggerEnter2D(Collider2D col)
    {

        foreach (int tagScore in tag_score)
        {
            if (col.gameObject.CompareTag(tagScore.ToString()))
            {
                UpdateScoreText(tagScore);
                break;
            }
        }


        if (col.gameObject.CompareTag("ball end"))
        {
            if (gameManager != null)
            {
                PlayerPrefs.SetInt("Score", score);
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
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
