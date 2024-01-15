using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ball_score : MonoBehaviour
{
    public int score = 100;
    public TMP_Text compteur;

    private int[] tag_score = { 5, 10, 20, 30, 40, 50, 60, 70, 80, 150 };

    private GameObject gameManager;

    private Life vie;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gamemanager");
        vie = gameManager.GetComponent<Life>();
        compteur.text = "Score : " + score.ToString();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("ball end"))
        {
            DestroyVie();

            if (gameManager != null && vie.nombreDeVies == 0)
            {
                PlayerPrefs.SetInt("Score", score);
                SceneManager.LoadScene("GameOver");
            }
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

    void DestroyVie()
    {
        if (gameManager != null)
        {
            vie.DecrementerVies();
            Destroy(gameObject);
        }
    }

    void UpdateScoreText(int a)
    {
        score += a;
        compteur.text = "Score : " + score.ToString();
    }
}