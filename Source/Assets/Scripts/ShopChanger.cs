using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopChanger : MonoBehaviour
{
    public GameObject Shop1;
    public GameObject Shop2;
    public GameObject Shop3;

    public void SHOP1()
    {
          Shop1.SetActive(true);
          Shop2.SetActive(false);
          Shop3.SetActive(false);
    }
    
    public void SHOP2()
    {
        Shop1.SetActive(false);
        Shop2.SetActive(true);
        Shop3.SetActive(false);
    }

    public void SHOP3()
    {
        Shop1.SetActive(false);
        Shop2.SetActive(false);
        Shop3.SetActive(true);
    }
}
