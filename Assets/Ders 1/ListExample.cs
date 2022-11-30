using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{

    public int ProductPrice = 50;

    public List<int> ProductPriceList = new();

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
      //  Debug.Log("Product Price = " + ProductPrice);
    }

    private void SetProductsPrice()
    {
        for (int i = 0; i < ProductPriceList.Count; i++)
        {
            ProductPriceList.Add(i);
         //   Debug.Log("Product" + i + " Price = " + 10);
        }
    }
    private void SetProductsPrice(int value)
    {
        for (int i = 0; i < ProductPriceList.Count; i++)
        {
            ProductPriceList.Add(value);
         //   Debug.Log("Product" + i + " Price = " + value);
        }
    }

    private void SetProductsPrice(int value,bool canUpdatePrice)
    {
        if (canUpdatePrice)
        {
            for (int i = 0; i < ProductPriceList.Count; i++)
            {
                ProductPriceList.Add(value);
             //   Debug.Log("Product" + i + " Price = " + value);

                // index numarasý belirtilen elemaný siler.
                ProductPriceList.Remove(5);
            }
        }
    }

}
