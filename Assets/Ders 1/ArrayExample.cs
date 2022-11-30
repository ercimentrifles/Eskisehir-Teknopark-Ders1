using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{

    public int ProductPrice = 50;

    public int[] ProductPriceList = new int[10];

    private void Start()
    {
        PrintProductPrice();

        // Normalde biz ayný method ismiyle baþka bir method oluþturamayýz. Ama Parametlerini deðiþtirerek
        // farklý iþlevler görmesini saðlayabiliriz.
        SetProductsPrice();
        SetProductsPrice(50);
        SetProductsPrice(100, true);
    }

    void PrintProductPrice()
    {
        Debug.Log("Product Price = " + ProductPrice);
    }

    private void SetProductsPrice()
    {
        for (int i = 0; i < ProductPriceList.Length; i++)
        {
            ProductPriceList[i] = 10;
         //   Debug.Log("Product" + i + " Price = " + 10);
        }
    }
    private void SetProductsPrice(int value)
    {
        for (int i = 0; i < ProductPriceList.Length; i++)
        {
            ProductPriceList[i] = value;
         //   Debug.Log("Product" + i + " Price = " + value);
        }
    }

    private void SetProductsPrice(int value,bool canUpdatePrice)
    {
        if (canUpdatePrice)
        {
            for (int i = 0; i < ProductPriceList.Length; i++)
            {
                ProductPriceList[i] = value;
             //   Debug.Log("Product" + i + " Price = " + value);
            }
        }
    }

}
