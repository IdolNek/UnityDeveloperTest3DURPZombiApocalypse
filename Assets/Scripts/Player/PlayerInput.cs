using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    [SerializeField] private GamePause _gamePause;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _gamePause.GamePaused();
        }
    }    
}
