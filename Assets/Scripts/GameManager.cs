using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoresText;
    public TextMeshProUGUI gameOverText;
    public GameObject rastartBatton;
    public int scores;
    public int health;
    public TextMeshProUGUI HP;
    
    // Start is called before the first frame update
    void Start()
    {
        scores = 0;
        scoresText.text = "scores: " + scores;
        gameOverText.gameObject.SetActive(false);
        rastartBatton.gameObject.SetActive(false);
        health = 3;
        HP.text = health + "/3 ";                      
    }
    public void UpdateScores(int addscores)
    {
        scores += addscores;
        scoresText.text = "scores: " + scores;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
