using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // inspector'da görebilirim. Set edebilirim.
    [SerializeField] private Player _player;

    private float _height;
    private int _hitPoint;
    public int HitPoint { get => _hitPoint; }

    // Getter Setter 


    private void Awake()
    {
        _hitPoint = 50;
        _height = 1.76f; // float deðerlerde sonuna mutlaka f yazýyoruz.
       // _player = GetComponent<Player>(); - Ayný GameObject'in compenentine ekliyse kullanýyoruz.
    }


    void Start()
    {
        Debug.Log("Player'ýn HP'si:"+ _player.HitPoint);
        Debug.Log("Player'ýn class adý:"+_player.name); // Büyük küçük harf dikkate alýnýyor. Buradaki name class1'in fieldý deðil adýdýr :)
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
      // methodun içinde oluþturulan bir deðiþken sadece o method içinde kullanýlabilir. Bu þekilde eriþemeyiz.
      //  int testHP = totalhp;
    }

    private void PrintTotalHP(int value)
    {
        Debug.Log("Total HP =" + value);
    }


}
