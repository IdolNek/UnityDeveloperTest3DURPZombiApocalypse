using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputPlayerNameMenu : MonoBehaviour
{
    [SerializeField] private GameObject _inputNameMenu;
    [SerializeField] private GameObject _startButton;
    [SerializeField] private TMP_InputField _inputFieldPlayerName;
    private string _playerName;
    public void PressStartGame()
    {
        if (_inputFieldPlayerName.text == "")
            _playerName = "Player";
        else _playerName = _inputFieldPlayerName.text;
        PlayerData.SetPlayerName(_playerName);
        gameObject.SetActive(false);
    }
    public void PressExitButton()
    {
        _inputNameMenu.SetActive(false);
        _startButton.SetActive(true);
    }
}