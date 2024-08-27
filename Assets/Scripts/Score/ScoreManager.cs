using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static public ScoreManager instance;
    [SerializeField] private ScoreUI scoreUI;
    [SerializeField] private int score;
    public int Score { 
        get => score;
        set
        { 
            score = value;  
            scoreUI.UpdateScore(score);
        }
    }
            
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
            Destroy(gameObject);

        Score = 0;
    }

    
}
