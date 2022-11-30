using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonStaticExample : MonoBehaviour
{
    void Start()
    {
       var newGame = CreateNewGame();

        newGame.GameName = "Yine adýný degistirebilirim.";

        Debug.Log("En son oyun adý=" + newGame.GameName);
    }

    private NonStaticBaseClass CreateNewGame()
    {
        NonStaticBaseClass newGameStaticClass = new NonStaticBaseClass("Eskisehir Teknopark Runner", NonStaticBaseClass.GameMode.Finished);

        Debug.Log("Yeni olusturdugumuz Game Adý:" + newGameStaticClass.GameName);
        Debug.Log("Yeni olusturdugumuz Game Statusü:" + newGameStaticClass.CurrentGameMode);

        return newGameStaticClass;
    }
}
