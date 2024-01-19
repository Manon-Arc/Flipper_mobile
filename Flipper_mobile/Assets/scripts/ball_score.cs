using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ball_score : MonoBehaviour
{
    public int score = 10;

    public TMP_Text compteur;

    private int[] tag_score = { 5, 10, 20, 30, 40, 50, 60, 70, 80, 150 };

    private GameObject test;

    public GameObject spawn_button;

    private GameObject life1;
    private GameObject life2;
    private GameObject life3;

    private void Start()
    {
        test = GameObject.FindGameObjectWithTag("Score");
        compteur = test.GetComponent<TextMeshPro>();

        life1 = GameObject.Find("Life1");
        life2 = GameObject.Find("Life2");
        life3 = GameObject.Find("Life3");

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

            if (life1)
            {
                Destroy(life1 );
                spawn_button.SetActive(true);
                Destroy(gameObject);
            }

            if (life2)
            {
                Destroy(life2 );
                spawn_button.SetActive(true);
                Destroy(gameObject);

            }

            if (life3)
            {
                Destroy(life3 );
                Destroy(gameObject);
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
