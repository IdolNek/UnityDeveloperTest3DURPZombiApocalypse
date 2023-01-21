using TMPro;
using UnityEngine;

public class GameScoreMonitor : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerScore;
    [SerializeField] private TMP_Text _zombieScore;
    [SerializeField] private GameScore _gameScore;
    private void OnEnable()
    {
        _gameScore.OnScoreChanged += OnScoreChanged;       
    }
    private void OnDisable()
    {
        _gameScore.OnScoreChanged += OnScoreChanged;
    }
    private void OnScoreChanged(int playerScore, int zombieScore)
    {
        _playerScore.text = playerScore.ToString();
        _zombieScore.text = zombieScore.ToString();
    }
}
