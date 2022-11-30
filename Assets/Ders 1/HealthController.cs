using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{

    /// Player ve Enemy HP lerini kontrol edeceðiz. Ýkisinin de HP lerini yazdýrýyoruz ve 
    /// Hangisinin daha fazla HP ye sahip olduðunu karþýlaþtýrarak öðreneceðiz ve yazdýracaðýz.
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
        // iki þekilde de eriþim saðlayabiliriz. public field ile ya da public method ile
        _playerHP = _player.HitPoint;
        _playerHP = _player.GetHP();
        _enemyHP = _enemy.HitPoint;
        // Player'ýn hp sini 50 olarak deðiþtirdik. Gerçeði deðiþtir gerçekten :)
        _player.HitPoint = 40;

        _playerHP = _player.HitPoint; // Player ve Enemy'nin HP deðiþim durumlarýný güncellemeliyiz. Eðer local birdeðiþkenle kontrol ediyorsak.
        Debug.Log("Player'ýn Hp si deðiþtirildi" + _player.HitPoint);
        // Get açýk ama Set kapalýysa biz sadece o alaný okuyabiliriz ama deðiþtiremeyiz.
        //   _enemy.HitPoint = 50;
        CheckHealths();

        Debug.Log("IsplayerHPLow Metodu:"+IsPlayerHPLow());

        // Bir diðer Kullaným IsplayerHPLow metodu için.

        // eðer doðru/ true ise
        if (IsPlayerHPLow())
        {

        }

        // yukarýdaki ile ayný ifade
        if (IsPlayerHPLow()==true)
        {

        }
        //

        // eðer yanlýþ/false ise
        if (!IsPlayerHPLow())
        {

        }

        // yukarýdaki ile ayný ifade
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
