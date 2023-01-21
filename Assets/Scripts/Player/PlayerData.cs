
public static class PlayerData
{    
    private static string _playerName;
    public static string PlayerName =>_playerName;
    public static void SetPlayerName(string playerName)
    {
        _playerName = playerName;
    }
}
