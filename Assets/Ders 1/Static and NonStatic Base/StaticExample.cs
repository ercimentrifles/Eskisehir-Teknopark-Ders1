using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticExample : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Oyunun ad�:"+StaticClass.GameName);

        Debug.Log("�u anki oyun durumu: "+StaticClass.CurrentGameMode);

        if (StaticClass.IsGamePlaying())
        {
            Debug.Log("Oyun Calisiyor");
        }
    }

}
