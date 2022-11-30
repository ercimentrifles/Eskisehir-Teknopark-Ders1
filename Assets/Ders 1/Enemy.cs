using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // inspector'da g�rebilirim. Set edebilirim.
    [SerializeField] private Player _player;

    private float _height;
    private int _hitPoint;
    public int HitPoint { get => _hitPoint; }

    // Getter Setter 


    private void Awake()
    {
        _hitPoint = 50;
        _height = 1.76f; // float de�erlerde sonuna mutlaka f yaz�yoruz.
       // _player = GetComponent<Player>(); - Ayn� GameObject'in compenentine ekliyse kullan�yoruz.
    }


    void Start()
    {
        Debug.Log("Player'�n HP'si:"+ _player.HitPoint);
        Debug.Log("Player'�n class ad�:"+_player.name); // B�y�k k���k harf dikkate al�n�yor. Buradaki name class1'in field� de�il ad�d�r :)
        Debug.Log("Enemy HP = " + _hitPoint);
        int totalHP = _hitPoint + _player.HitPoint;
        PrintTotalHP(totalHP);
        GetPlayerHP();
    }

    private void GetPlayerHP()
    {
        int playerHP = _player.GetHP();
        Debug.Log("Get ile alinan Playerin HPsi = " + playerHP);
    }



    private void ExampleError1()
    {
      // methodun i�inde olu�turulan bir de�i�ken sadece o method i�inde kullan�labilir. Bu �ekilde eri�emeyiz.
      //  int testHP = totalhp;
    }

    private void PrintTotalHP(int value)
    {
        Debug.Log("Total HP =" + value);
    }


}
