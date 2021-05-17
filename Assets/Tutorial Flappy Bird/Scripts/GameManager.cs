using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //새가 죽었을 때
    static public GameManager instance;
    public GameObject gameOverUI;
    public Text scoreUI;
    // Start is called before the first frame update
 
    private void Awake()
    {
        instance = this;
        gameOverUI.SetActive(false);
    }
    bool isGameOver;

    internal void SetGameOver() 
    {
        isGameOver = true;
        ShowGameOver(true);
    }
    internal void ShowGameOver(bool active)
    {
        gameOverUI.SetActive(active);
    }
    int score;
    internal void AddScore() {
        score += 100;
        scoreUI.text = "Score :" + score;
    }

    private void Update() 
    {
        if(isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        }
    }
    
}
