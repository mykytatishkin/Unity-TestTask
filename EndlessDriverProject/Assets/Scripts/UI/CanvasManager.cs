using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasManager : MonoBehaviour
{

    public TMP_Text timeText;

    public GameObject endGamePanel;
    public TMP_Text runTimeText;
    public TMP_Text highScoreText;

    public float elapsedTime;
    public float startTime;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }

    public void UpdateTime()
    {
        elapsedTime = Time.time - startTime;
    }

    public void EndGame()
    {
        // TODO: Setup EndGame Panel
    }

    public void RestartGame()
    {
        // TODO: Restart the game
    }

    public void QuitGame()
    {
        // TODO: Quit Game
    }
}
