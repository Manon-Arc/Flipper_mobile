using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class ball_score : MonoBehaviour
{
    GameManage score_game;

    GameObject gameManager;

    private int[] tag_score = { 5, 10, 20, 30, 40, 50, 60, 70, 80, 150 };

    private GameObject test;

    private GameObject spawn_button;

    private GameObject life1;
    private GameObject life2;
    private GameObject life3;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gamemanager");
        score_game = gameManager.GetComponent<GameManage>();

        spawn_button = GameObject.Find("Ball_spawn");
        spawn_button.SetActive(false);

        life1 = GameObject.Find("Life1");
        life2 = GameObject.Find("Life2");
        life3 = GameObject.Find("Life3");

    }

    private void OnDestroy()
    {
        spawn_button?.SetActive(true);
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
            if (life3 != null && life2 == null && life1 == null)
            {
                Destroy(life3);
                PlayerPrefs.SetInt("Score", score_game.score_int);
                SceneManager.LoadScene("GameOver");
            }

            if (life2 != null && life1 == null && life3 != null)
            {
                Destroy(life2);
                Destroy(gameObject);
            }

            if (life1 != null && life2 != null && life3 != null)
            {
                Destroy(life1);
                Destroy(gameObject);   
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
        score_game.UpdateScore(a);
    }
}
