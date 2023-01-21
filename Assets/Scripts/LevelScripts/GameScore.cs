using UnityEngine;
using Opsive.Shared.Events;
using UnityEngine.Events;

public class GameScore : MonoBehaviour
{
    private int _playerScore;
    private int _zombieScore;
    public UnityAction<int, int> OnScoreChanged;
    public void PlayerDied()
    {
        _zombieScore++;
        OnScoreChanged?.Invoke(_playerScore, _zombieScore);
    }
    public void ZombieDied()
    {
        _playerScore++;
        OnScoreChanged?.Invoke(_playerScore, _zombieScore);
    }
}

