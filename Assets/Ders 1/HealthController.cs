using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{

    /// Player ve Enemy HP lerini kontrol edece�iz. �kisinin de HP lerini yazd�r�yoruz ve 
    /// Hangisinin daha fazla HP ye sahip oldu�unu kar��la�t�rarak ��renece�iz ve yazd�raca��z.
    /// 

    [SerializeField] private Player _player;
    [SerializeField] private Enemy _enemy;

    private int _playerHP;
    private int _enemyHP;

    private Transform _transform;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _transform = transform;
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        // iki �ekilde de eri�im sa�layabiliriz. public field ile ya da public method ile
        _playerHP = _player.HitPoint;
        _playerHP = _player.GetHP();
        _enemyHP = _enemy.HitPoint;
        // Player'�n hp sini 50 olarak de�i�tirdik. Ger�e�i de�i�tir ger�ekten :)
        _player.HitPoint = 40;

        _playerHP = _player.HitPoint; // Player ve Enemy'nin HP de�i�im durumlar�n� g�ncellemeliyiz. E�er local birde�i�kenle kontrol ediyorsak.
        Debug.Log("Player'�n Hp si de�i�tirildi" + _player.HitPoint);
        // Get a��k ama Set kapal�ysa biz sadece o alan� okuyabiliriz ama de�i�tiremeyiz.
        //   _enemy.HitPoint = 50;
        CheckHealths();

        Debug.Log("IsplayerHPLow Metodu:"+IsPlayerHPLow());

        // Bir di�er Kullan�m IsplayerHPLow metodu i�in.

        // e�er do�ru/ true ise
        if (IsPlayerHPLow())
        {

        }

        // yukar�daki ile ayn� ifade
        if (IsPlayerHPLow()==true)
        {

        }
        //

        // e�er yanl��/false ise
        if (!IsPlayerHPLow())
        {

        }

        // yukar�daki ile ayn� ifade
        if (IsPlayerHPLow()==false)
        {

        }
        ///


        ///

        bool isPlayerHPHight = !IsPlayerHPLow();

        Debug.Log("isplayerHPHight:" + isPlayerHPHight);

    }
    private void CheckHealths()
    {
        if (_playerHP > _enemyHP)
        {
            Debug.Log("CheckHealts Metodu: Player daha fazla HP ye sahip");
        }
        else
        {
            Debug.Log("CheckHealts Metodu: Enemy daha fazla HP ye sahip");
        }
    }

    private bool IsPlayerHPLow()
    {
        if (_player.HitPoint<_enemy.HitPoint)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
