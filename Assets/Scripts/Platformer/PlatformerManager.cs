using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PlatformerManager : Singleton<PlatformerManager>
{
    public int winner;
    float timeTaken;
    List<int> group1Movements = new List<int>{1,2,4};
    List<int> group2Movements = new List<int>{0,3};
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;
    [SerializeField] GameObject player2Camera;
    [SerializeField] GameObject player2Score;
    [SerializeField] GameObject endPanel;
    [SerializeField] Text winnerText;
    [SerializeField] Text timeCoinsText;
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    [SerializeField] GameObject totalTimer;
    [SerializeField] GameObject timer;

    protected override void Awake() {
        base.Awake();
        int group1Player = Random.Range(0,2);
        if(PlayerPrefs.GetInt("Multiplayer") == 1){
            player2.SetActive(true);
            player2Camera.SetActive(true);
            player2Score.SetActive(true);
        }
        if(!player2.activeSelf){
            if(group1Player == 0){
                player1.GetComponent<PlatformerMovement>().movementType = (PlatformerMovement.MovementType)group1Movements[Random.Range(0,3)];
            }
            else{
                player1.GetComponent<PlatformerMovement>().movementType = (PlatformerMovement.MovementType)group2Movements[Random.Range(0,2)];
            }
        }
        else{
            if(group1Player == 0){
                player1.GetComponent<PlatformerMovement>().movementType = (PlatformerMovement.MovementType)group1Movements[Random.Range(0,3)];
                player2.GetComponent<PlatformerMovement>().movementType = (PlatformerMovement.MovementType)group2Movements[Random.Range(0,2)];
            }
            else{
                player2.GetComponent<PlatformerMovement>().movementType = (PlatformerMovement.MovementType)group1Movements[Random.Range(0,3)];
                player1.GetComponent<PlatformerMovement>().movementType = (PlatformerMovement.MovementType)group2Movements[Random.Range(0,2)];
            }
        }
        timeTaken = 0;
    }

    private void Update() {
        timeTaken += Time.deltaTime;
    }

    public void SetupEnd(){
        timer.SetActive(false);
        totalTimer.SetActive(false);
        player1.SetActive(false);
        player2.SetActive(false);
        int coins = 0;
        if(!player2.activeSelf){
            winnerText.text = "You Win!";
        }
        else if(winner == 1){
            winnerText.text = "Player 1 Won!";
            coins = PlayerPrefs.GetInt("Player1");
        }
        else{
            winnerText.text = "Player 2 Won!";
            coins = PlayerPrefs.GetInt("Player2");
        }
        timeCoinsText.text = "Time: " + timeTaken.ToString("F2") + "s   Coins: " + coins;
        int score = (int) (Mathf.Max(300 - timeTaken, 0) + coins * 3);
        if(score > PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore", score);
        }
        scoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
        endPanel.SetActive(true);
    }

    public void PlayAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToHUB(){
        GetComponent<PlayerInputManager>().splitScreen = false;
        SceneManager.LoadScene("Menu");
    }
}
