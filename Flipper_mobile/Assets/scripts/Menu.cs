using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void Redirect_Start()
    {
        SceneManager.LoadScene("Game");
    }
}
