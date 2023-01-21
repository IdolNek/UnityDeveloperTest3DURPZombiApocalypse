using TMPro;
using UnityEngine;

public class PlayerNameMonitor : MonoBehaviour
{
    [SerializeField] private TMP_Text _playername;
    private void Start()
    {
        _playername.text = PlayerData.PlayerName;
    }
}
