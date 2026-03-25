using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static int score = 0;
    public static int fruitsCut = 0;
    private static int lives = 10;

    public Text t_lives;

    public void LoseLife()
    {
        lives--;
        t_lives.text = lives.ToString();
        if(lives <= 0)
        {
            SceneManager.LoadScene("Start");
        }
    }
}
