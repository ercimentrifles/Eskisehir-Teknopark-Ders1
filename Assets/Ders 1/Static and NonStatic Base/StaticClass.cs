using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 public  class StaticClass 
{
    public enum GameMode
    {
        Playing,
        Finished
    }

    public static GameMode CurrentGameMode = GameMode.Playing;
    
    public static string GameName = "Test Game";

    public StaticClass(string name,GameMode newGameMode)
    {
        CurrentGameMode = newGameMode;
        GameName = name;
    }

    public static bool IsGamePlaying()
    {
        return true;
    }
}
