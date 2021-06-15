using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            Debug.Log("Game Over!");
            lives = 0;
        }
        else
        {
            Debug.Log("Lives: " + lives);
        }
    }

    public void addScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }
}
