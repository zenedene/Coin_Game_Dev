using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
