using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI lives;
    public TextMeshProUGUI scores;
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

    public void PointUp()
    {
        score++;
        UpdateHealthAndScore();
    }
    public void TakeDamage()
    {
        health--;
        UpdateHealthAndScore();
    }

    void UpdateHealthAndScore()
    {
        lives.text = $"Lives: {health}";
        scores.text = $"Score: {score}";
    }
}
