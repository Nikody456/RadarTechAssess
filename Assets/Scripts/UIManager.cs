using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public MenuScript menu;
    public GameObject lostText;

    public Text scoreText;
    public Text livesText;
    public int score = 0;
    public int lives = 3;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        livesText.text = "Lives: " + lives.ToString();
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 7;
        scoreText.text = "Score: " + score.ToString();
    }

    public void DecreaseLives()
    {
        lives -= 1;
        livesText.text = "Lives: " + lives.ToString();
        if (lives == -1)
        {
            menu.OpenMenu();
            lostText.SetActive(true);
            livesText.text = "";
        }
    }
}
