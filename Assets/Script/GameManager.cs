using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI livesandScore;
    public int health;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void TakeDamage()
    {
        health--;
        UpdateHealthAndScore();
    }

    void UpdateHealthAndScore()
    {
        livesandScore.text = $"Lives: {health}";
    }
}
