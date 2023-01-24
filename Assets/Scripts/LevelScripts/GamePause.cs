using UnityEngine;
using Opsive.Shared.Events;

public class GamePause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _player;
    private bool isGamePaused = false;
    public void GamePaused()
    {
        if (isGamePaused)
        {
            EventHandler.ExecuteEvent(_player, "OnEnableGameplayInput", true);
            isGamePaused = false;
            _pauseMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;
        }
        else
        {
            EventHandler.ExecuteEvent(_player, "OnEnableGameplayInput", false);
            isGamePaused = true;
            _pauseMenu.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
