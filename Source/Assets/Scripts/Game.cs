using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    public TMP_Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;
    public float CurrentButton;

    public GameObject Cat1;
    public GameObject Cat2;
    public GameObject Cat3;
    public GameObject Cat4;
    public GameObject Cat5;
    public GameObject Cat6;
    public GameObject Cat7;
    public GameObject Cat8;
    public GameObject Cat9;
    public GameObject Cat10;
    public GameObject Cat11;
    public GameObject Cat12;
    public GameObject Cat13;
    public GameObject Cat14;
    public GameObject Cat15;
    public GameObject Cat16;
    public GameObject Cat17;
    public GameObject Cat18;
    public GameObject Cat19;
    public GameObject Cat20;

    public int shop1price;
    public TMP_Text shop1text;
    public TMP_Text shop1bt;

    public int shop2price;
    public TMP_Text shop2text;
    public TMP_Text shop2bt;

    public int shop3price;
    public TMP_Text shop3text;
    public TMP_Text shop3bt;

    public int shop4price;
    public TMP_Text shop4text;
    public TMP_Text shop4bt;

    public int shop5price;
    public TMP_Text shop5text;
    public TMP_Text shop5bt;

    public int shop6price;
    public TMP_Text shop6text;
    public TMP_Text shop6bt;

    void Start()
    {
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 0;
        x = 0f;
        CurrentButton = 0;

        currentScore = PlayerPrefs.GetInt("currentScore", 0);
        CurrentButton = PlayerPrefs.GetInt("CurrentButton", 0);
        hitPower = PlayerPrefs.GetInt("hitPower", 1);
        if (hitPower < 1)
        {
            hitPower = 1;
            PlayerPrefs.SetInt("hitPower", 1); // korrigierten Wert zurückspeichern
        }
        scoreIncreasedPerSecond = PlayerPrefs.GetInt("scoreIncreasedPerSecond", 0);
        x = PlayerPrefs.GetInt("x", 0);
        shop1price = PlayerPrefs.GetInt("shop1price", 25);
        shop2price = PlayerPrefs.GetInt("shop2price", 100);
        shop3price = PlayerPrefs.GetInt("shop3price", 400);
        shop4price = PlayerPrefs.GetInt("shop4price", 400);
        shop5price = PlayerPrefs.GetInt("shop5price", 800);
        shop6price = PlayerPrefs.GetInt("shop6price", 1600);
    }

    void Update()
    {
        scoreText.text = "Cats: " + (int)currentScore;

        // Punkte pro Sekunde berechnen
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore += scoreIncreasedPerSecond;

        // Shoptexte updaten
        shop1text.text = "Autoclicker 1: " + shop1price + " Cats";
        shop2text.text = "Autoclicker 2: " + shop2price + " Cats";
        shop3text.text = "Next Button: " + shop3price + " Cats";
        shop4text.text = "Autoclicker 3: " + shop4price + " Cats";
        shop5text.text = "Upgrade Cats per Click: " + shop5price + " Cats";
        shop6text.text = "Upgrade Cats per Second: " + shop6price + " Cats";

        if (shop1price == 100)
        {
            shop1text.text = "Autoclicker 1: Maxed out";
            shop1bt.text = "Maxed out";
        }

        if (shop2price == 400)
        {
            shop2text.text = "Autoclicker 2: Maxed out";
            shop2bt.text = "Maxed out";
        }
            
        if (shop3price == 419430400)
        {
            shop3text.text = "Next Button: Maxed out";
            shop3bt.text = "Maxed out";
        }

        if (shop4price == 1600)
        {
            shop4text.text = "Autoclicker 3: Maxed out";
            shop4bt.text = "Maxed out";
        }

        if (shop5price == 125)
        {
            shop5text.text = "Upgrade Cats per Click: Maxed out";
            shop5bt.text = "Maxed out";
        }

        if (shop6price == 6400)
        {
            shop6text.text = "Upgrade Cats per Second: Maxed out";
            shop6bt.text = "Maxed out";
        }

        PlayerPrefs.SetInt("currentScore", (int)currentScore);
        PlayerPrefs.SetInt("CurrentButton", (int)CurrentButton);
        PlayerPrefs.SetInt("hitPower", (int)hitPower);
        PlayerPrefs.SetInt("scoreIncreasedPerSecond", (int)scoreIncreasedPerSecond);
        PlayerPrefs.SetInt("x", (int)x);
        PlayerPrefs.SetInt("shop1price", (int)shop1price);
        PlayerPrefs.SetInt("shop2price", (int)shop2price);
        PlayerPrefs.SetInt("shop3price", (int)shop3price);
        PlayerPrefs.SetInt("shop4price", (int)shop4price);
        PlayerPrefs.SetInt("shop5price", (int)shop5price);
        PlayerPrefs.SetInt("shop6price", (int)shop6price);
    }

    public void Hit()
    {
        currentScore += hitPower;
    }

    public void Shop1()
    {
        if (shop1price <= 75)
        {
            if (currentScore >= shop1price)
            {
                currentScore -= shop1price;
                x += 1;
                shop1price += 25;
            }
        }
    }

    public void Shop2()
    {
        if (shop2price <= 300)
        {
            if (currentScore >= shop2price)
            {
                currentScore -= shop2price;
                x += 2;
                shop2price += 100;
            }
        }
    }

    public void Shop3()
    {
        if (shop3price <= 838860800)
        {
            if (currentScore >= shop3price)
            {
                currentScore -= shop3price;
                shop3price *= 2;
                CurrentButton += 1;
                hitPower *= 2;
                x *= 2;
            }
        }
    }

    public void Shop4()
    {
        if (shop4price <= 1200)
        {
            if (currentScore >= shop4price)
            {
                currentScore -= shop4price;
                x += 4;
                shop4price += 400;
            }
        }
    }

    public void Shop5()
    {
        if (shop5price <= 21600)
        {
            if (currentScore >= shop5price)
            {
                currentScore -= shop5price;
                hitPower *= 2;
                shop5price *= 3;
            }
        }
    }

    public void Shop6()
    {
        if (shop6price <= 43200)
        {
            if (currentScore >= shop6price)
            {
                currentScore -= shop6price;
                x *= 2;
                shop6price *= 3;
            }
        }
    }

    public void CB()
    {
        if (CurrentButton == 1)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(true);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }

        if (CurrentButton == 2)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(true);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }

        if (CurrentButton == 3)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(true);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }

        if (CurrentButton == 4)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(true);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }
        
        if (CurrentButton == 5)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(true);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }
        
        if (CurrentButton == 6)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(true);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }
        
        if (CurrentButton == 7)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(true);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }
        
        if (CurrentButton == 8)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(true);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }
        
        if (CurrentButton == 9)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(true);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }
        
        if (CurrentButton == 10)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(true);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }
        
        if (CurrentButton == 11)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(true);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }

        if (CurrentButton == 12)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(true);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }

        if (CurrentButton == 13)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(true);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }

        if (CurrentButton == 14)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(true);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }

        if (CurrentButton == 15)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(true);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }

        if (CurrentButton == 16)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(true);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }

        if (CurrentButton == 17)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(true);
            Cat19.SetActive(false);
            Cat20.SetActive(false);
        }

        if (CurrentButton == 18)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(true);
            Cat20.SetActive(false);
        }

        if (CurrentButton == 19)
        {
            Cat1.SetActive(false);
            Cat2.SetActive(false);
            Cat3.SetActive(false);
            Cat4.SetActive(false);
            Cat5.SetActive(false);
            Cat6.SetActive(false);
            Cat7.SetActive(false);
            Cat8.SetActive(false);
            Cat9.SetActive(false);
            Cat10.SetActive(false);
            Cat11.SetActive(false);
            Cat12.SetActive(false);
            Cat13.SetActive(false);
            Cat14.SetActive(false);
            Cat15.SetActive(false);
            Cat16.SetActive(false);
            Cat17.SetActive(false);
            Cat18.SetActive(false);
            Cat19.SetActive(false);
            Cat20.SetActive(true);
        }
    }
}
