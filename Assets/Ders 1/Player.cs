using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    /// <summary>
    /// Yazým Kurallarý : 
    /// Public Büyük harf baþlar. Her kelimenin ilk harfi büyük
    /// Private _ ile baþlar ilk harf küçük 
    /// </summary>

    public int HitPoint; // Her yerden eriþebiliriz.
    protected string Name;  // Sadece kalýtým verilen yerlerden.
    private float _height;  // dýþarýdan eriþime kapalý
    private bool _isAlive;
    /// <summary>
    /// void : geriye deðer göndermiyor. / int / string / float / bool vb. deðerler geriye gönderebilir.
    /// </summary>
    /// <param name="value"></param>
    /// 


    // Ýlk çalýþan method. Oyun yüklenmeden çalýþýr
    private void Awake()
    {
        Debug.Log("Awake Çalýþtý:");
        _height = 1.93f;
        SetHP();

    }

    // Aktif olduðunda çalýþýr.
    private void OnEnable()
    {
        Debug.Log("OnEnable Çalýþtý:");
    }
    private void Start()
    {
        Debug.Log("Start Çalýþtý:");

        StartCoroutine(WhileLoopExample());
    }
    private void Update()
    {

        /*
        // ileride öðreneceðiz.
        if (Input.GetKeyDown(KeyCode.Space))
        {

            // Belirli sayýda bir iþlemin tekrar etmesini saðlar.
            for (int i = 0; i < 10; i++)
            {
                HitPoint++; // bir arttýr, altaki örnekler ayný sonucu verir.
            //    HitPoint += 1;
            //    HitPoint = HitPoint + 1;

              //  Debug.Log("Player HP arttý:" + HitPoint);
            }
        }

        */

    }
    private void FixedUpdate()
    {

    }
    private void OnDisable()
    {
        Debug.Log("Disable  Çalýþtý:");
    }
    private void OnDestroy()
    {
        Debug.Log("Destroy Çalýþtý:");
    }


    // Örnek olay : Oyun baþladýðýnda 
    //Oyuncunun HitPointi 100 olsun
    private void SetHP()
    {
        HitPoint = 100;

        Debug.Log(HitPoint);
    }

    public int GetHP()
    {
        return HitPoint;
     //   return 3; geriye bir int deðer gönderir ;  farklý variable türleride olabilir. yukarýda tanýmlamak lazým.
    }



    // Ne olduðunu sonradan öðreneceksiniz

     private IEnumerator WhileLoopExample()
    {

        /*
        while (true)
        {
            // sonsuz döngü
        }
        */


        // HitPoint 100 den küçük olduðu sürece çalýþ 

        yield return new WaitForSeconds(1);
        while (HitPoint<100)
        {
            HitPoint++;
           // Debug.Log("While Döngüsü HitPoint:" + HitPoint);
            yield return null;
        }
    }
}


