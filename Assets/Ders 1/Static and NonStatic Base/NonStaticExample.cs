using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonStaticExample : MonoBehaviour
{
    void Start()
    {
       var newGame = CreateNewGame();

        newGame.GameName = "Yine ad�n� degistirebilirim.";

        Debug.Log("En son oyun ad�=" + newGame.GameName);
    }

    private NonStaticBaseClass CreateNewGame()
    {
        NonStaticBaseClass newGameStaticClass = new NonStaticBaseClass("Eskisehir Teknopark Runner", NonStaticBaseClass.GameMode.Finished);

        Debug.Log("Yeni olusturdugumuz Game Ad�:" + newGameStaticClass.GameName);
        Debug.Log("Yeni olusturdugumuz Game Status�:" + newGameStaticClass.CurrentGameMode);

        return newGameStaticClass;
    }
}
