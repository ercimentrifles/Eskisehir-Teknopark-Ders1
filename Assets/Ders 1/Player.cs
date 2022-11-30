using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    /// <summary>
    /// Yaz�m Kurallar� : 
    /// Public B�y�k harf ba�lar. Her kelimenin ilk harfi b�y�k
    /// Private _ ile ba�lar ilk harf k���k 
    /// </summary>

    public int HitPoint; // Her yerden eri�ebiliriz.
    protected string Name;  // Sadece kal�t�m verilen yerlerden.
    private float _height;  // d��ar�dan eri�ime kapal�
    private bool _isAlive;
    /// <summary>
    /// void : geriye de�er g�ndermiyor. / int / string / float / bool vb. de�erler geriye g�nderebilir.
    /// </summary>
    /// <param name="value"></param>
    /// 


    // �lk �al��an method. Oyun y�klenmeden �al���r
    private void Awake()
    {
        Debug.Log("Awake �al��t�:");
        _height = 1.93f;
        SetHP();

    }

    // Aktif oldu�unda �al���r.
    private void OnEnable()
    {
        Debug.Log("OnEnable �al��t�:");
    }
    private void Start()
    {
        Debug.Log("Start �al��t�:");

        StartCoroutine(WhileLoopExample());
    }
    private void Update()
    {

        /*
        // ileride ��renece�iz.
        if (Input.GetKeyDown(KeyCode.Space))
        {

            // Belirli say�da bir i�lemin tekrar etmesini sa�lar.
            for (int i = 0; i < 10; i++)
            {
                HitPoint++; // bir artt�r, altaki �rnekler ayn� sonucu verir.
            //    HitPoint += 1;
            //    HitPoint = HitPoint + 1;

              //  Debug.Log("Player HP artt�:" + HitPoint);
            }
        }

        */

    }
    private void FixedUpdate()
    {

    }
    private void OnDisable()
    {
        Debug.Log("Disable  �al��t�:");
    }
    private void OnDestroy()
    {
        Debug.Log("Destroy �al��t�:");
    }


    // �rnek olay : Oyun ba�lad���nda 
    //Oyuncunun HitPointi 100 olsun
    private void SetHP()
    {
        HitPoint = 100;

        Debug.Log(HitPoint);
    }

    public int GetHP()
    {
        return HitPoint;
     //   return 3; geriye bir int de�er g�nderir ;  farkl� variable t�rleride olabilir. yukar�da tan�mlamak laz�m.
    }



    // Ne oldu�unu sonradan ��reneceksiniz

     private IEnumerator WhileLoopExample()
    {

        /*
        while (true)
        {
            // sonsuz d�ng�
        }
        */


        // HitPoint 100 den k���k oldu�u s�rece �al�� 

        yield return new WaitForSeconds(1);
        while (HitPoint<100)
        {
            HitPoint++;
           // Debug.Log("While D�ng�s� HitPoint:" + HitPoint);
            yield return null;
        }
    }
}


