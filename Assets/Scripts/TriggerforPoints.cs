using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class TriggerforPoints : MonoBehaviour
{
    public TextMeshProUGUI friendsText;
    public TextMeshProUGUI enemiesText;
    public TextMeshProUGUI timerText;
    public int scoreFriends;
    public int scoreEnemies;
    public GameObject gameOverPanel;
    public GameObject winPanel;
    public float timer;
    private AudioManager _audioManager;

    private void Awake()
    {
        UIText();
        DisplayTime();

        _audioManager = FindObjectOfType<AudioManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreFriends = 0; // start with 0 points
        scoreEnemies = 3; // start with 3 lives
        gameOverPanel.SetActive(false); // turn off GameOverPanel
        winPanel.SetActive(false); // turn off WinPanel
        timer = 30f; // StartTime
    }
    // Update is called once per frame
    private void Update()
    {
        UIText();
        DisplayTime();
        
        // Conditions to win or fail
        if (timer <= 0 && scoreFriends < 10) // fail Condition
        {
            GameOver();
        }
        
        if (scoreEnemies <= 0) // other fail condition
        {
            GameOver(); 
        }

        if (timer <= 0 && scoreFriends >= 10) // win condition
        {
            Win();
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        // if Player collides with Friend + score
        if (other.gameObject.CompareTag("Friend")) 
        {
            // Debug.Log("Friendo! +1");
            scoreFriends++;
            _audioManager.BefriendSound();
        }
        
        // if Player collides with enemy -score and -live
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Debug.Log("noooo -1");
            scoreEnemies--;
        }
    }
    public void UIText()
    {
        //Text set up
        friendsText.text = "Kindness: " + scoreFriends + " /10";
        enemiesText.text = "Faults: " + scoreEnemies + " /3";
    }
    public void DisplayTime()
    {
        // Timer / Countdown Set up
        timer -= Time.deltaTime;  // counting seconds down
        int minutes = Mathf.FloorToInt(timer / 60f); 
        int seconds = Mathf.FloorToInt(timer % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Display Timer ; Format / Text
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true); // show GameOverPanel
    }
    void Win()
    {
        winPanel.SetActive(true); // show WinPanel
    }
}
