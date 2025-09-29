using UnityEngine;
using UnityEngine.UI;

public class ChangeLog : MonoBehaviour
{
    public GameObject ShopButton;
    public GameObject ChangeLogButton;
    public GameObject CL;
    public GameObject Cat1;
    public GameObject Cats;
    public GameObject Version;

    public void OpenCL()
    {
        ShopButton.SetActive(false);
        Cat1.SetActive(false);
        Cats.SetActive(false);
        Version.SetActive(false);
        ChangeLogButton.SetActive(false);
        CL.SetActive(true);
        
    }

    public void CloseCL()
    {
        ShopButton.SetActive(true);
        Cat1.SetActive(true);
        Cats.SetActive(true);
        Version.SetActive(true);
        ChangeLogButton.SetActive(true);
        CL.SetActive(false);
    }
}
