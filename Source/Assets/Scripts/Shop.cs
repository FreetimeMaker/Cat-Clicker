using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject ShopButton;
    public GameObject ChangeLogButton;
    public GameObject SHOP;
    public GameObject Cat1;
    public GameObject Cats;
    public GameObject Version;
    public GameObject Hintergrund;

    public void OpenShop()
    {
        ShopButton.SetActive(false);
        SHOP.SetActive(true);
        Cat1.SetActive(false);
        Cats.SetActive(false);
        Version.SetActive(false);
        ChangeLogButton.SetActive(false);
        Hintergrund.SetActive(false);
    }

    public void CloseShop()
    {
        ShopButton.SetActive(true);
        SHOP.SetActive(false);
        Cat1.SetActive(true);
        Cats.SetActive(true);
        Version.SetActive(true);
        ChangeLogButton.SetActive(true);
        Hintergrund.SetActive(true);
    }
}
