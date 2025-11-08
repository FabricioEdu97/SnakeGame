using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] int score;

    public void SetScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
    }
}
