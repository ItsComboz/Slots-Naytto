using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChanceTable : MonoBehaviour
{

    // Different Squeres
    public string Symbol1;
    public string Symbol2;
    public string Symbol3;
    public string Symbol4;
    public string Symbol5;
    public string Symbol6;
    public string Symbol7;
    public string Symbol8;
    public string Symbol9;

    //Sylbols
    public GameObject Berry1;
    public GameObject Berry2;
    public GameObject Berry3;
    public GameObject Berry4;
    public GameObject Berry5;
    public GameObject Berry6;
    public GameObject Berry7;
    public GameObject Berry8;
    public GameObject Berry9;

    public GameObject Apple1;
    public GameObject Apple2;
    public GameObject Apple3;
    public GameObject Apple4;
    public GameObject Apple5;
    public GameObject Apple6;
    public GameObject Apple7;
    public GameObject Apple8;
    public GameObject Apple9;

    public GameObject Orange1;
    public GameObject Orange2;
    public GameObject Orange3;
    public GameObject Orange4;
    public GameObject Orange5;
    public GameObject Orange6;
    public GameObject Orange7;
    public GameObject Orange8;
    public GameObject Orange9;

    public GameObject Coin1;
    public GameObject Coin2;
    public GameObject Coin3;
    public GameObject Coin4;
    public GameObject Coin5;
    public GameObject Coin6;
    public GameObject Coin7;
    public GameObject Coin8;
    public GameObject Coin9;

    public GameObject Diamond1;
    public GameObject Diamond2;
    public GameObject Diamond3;
    public GameObject Diamond4;
    public GameObject Diamond5;
    public GameObject Diamond6;
    public GameObject Diamond7;
    public GameObject Diamond8;
    public GameObject Diamond9;

    public GameObject Ace1;
    public GameObject Ace2;
    public GameObject Ace3;
    public GameObject Ace4;
    public GameObject Ace5;
    public GameObject Ace6;
    public GameObject Ace7;
    public GameObject Ace8;
    public GameObject Ace9;

    public GameObject Seven1;
    public GameObject Seven2;
    public GameObject Seven3;
    public GameObject Seven4;
    public GameObject Seven5;
    public GameObject Seven6;
    public GameObject Seven7;
    public GameObject Seven8;
    public GameObject Seven9;

    //Rolls
    public Roll_1 noppa1;
    public Roll_1 noppa2;
    public Roll_1 noppa3;
    public Roll_1 noppa4;
    public Roll_1 noppa5;
    public Roll_1 noppa6;
    public Roll_1 noppa7;
    public Roll_1 noppa8;
    public Roll_1 noppa9;
    

    public ScoreCount Score;

    // Chances (Make sure all ways full 100% and no over laps)

    private int a1 = 1; private int a2 = 36;
    private int b1 = 36; private int b2 = 51;
    private int c1 = 51; private int c2 = 61;
    private int d1 = 61; private int d2 = 71;
    private int e1 = 71; private int e2 = 91;
    private int f1 = 91; private int f2 = 96;
    private int g1 = 96; private int g2 = 101;

    // Update is called once per frame
    void Update() 
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            noppa1.GenerateNumbers();
            noppa2.GenerateNumbers();
            noppa3.GenerateNumbers();
            noppa4.GenerateNumbers();
            noppa5.GenerateNumbers();
            noppa6.GenerateNumbers();
            noppa7.GenerateNumbers();
            noppa8.GenerateNumbers();
            noppa9.GenerateNumbers();

            Score.CountScore(this);
        }


        //if (gameObject.CompareTag("1"))
        {
            if (noppa1.Randomice >= a1 && noppa1.Randomice <= a2)
            {
                Symbol1 = "Berry";
            }else if (noppa1.Randomice >= b1 && noppa1.Randomice <= b2)
            {
                Symbol1 = "Aples";
            }
            else if (noppa1.Randomice >= c1 && noppa1.Randomice <= c2)
            {
                Symbol1 = "Coins";
            }
            else if (noppa1.Randomice >= d1 && noppa1.Randomice <= d2)
            {
                Symbol1 = "Orange";
            }
            else if (noppa1.Randomice >= e1 && noppa1.Randomice <= e2)
            {
                Symbol1 = "Ace";
            }
            else if (noppa1.Randomice >= f1 && noppa1.Randomice <= f2)
            {
                Symbol1 = "Diamond";
            }
            else if (noppa1.Randomice >= g1 && noppa1.Randomice <= g2)
            {
                Symbol1 = "7";
            }
        }
        {
            if(Symbol1 == "Berry")
            {
                Berry1.SetActive(true);
            }else
            {
                Berry1.SetActive(false);
            }

            if (Symbol1 == "Aples")
            {
                Apple1.SetActive(true);
            }
            else
            {
                Apple1.SetActive(false);
            }

            if (Symbol1 == "Coins")
            {
                Coin1.SetActive(true);
            }
            else
            {
                Coin1.SetActive(false);
            }

            if (Symbol1 == "Orange")
            {
                Orange1.SetActive(true);
            }
            else
            {
                Orange1.SetActive(false);
            }

            if (Symbol1 == "Diamond")
            {
                Diamond1.SetActive(true);
            }
            else
            {
                Diamond1.SetActive(false);
            }

            if (Symbol1 == "Ace")
            {
                Ace1.SetActive(true);
            }
            else
            {
                Ace1.SetActive(false);
            }

            if (Symbol1 == "7")
            {
                Seven1.SetActive(true);
            }
            else
            {
                Seven1.SetActive(false);
            }


        }

        //if (gameObject.CompareTag("2"))
        {
            if (noppa2.Randomice >= a1 && noppa2.Randomice <= a2)
            {
                Symbol2 = "Berry";
            }
            else if (noppa2.Randomice >= b1 && noppa2.Randomice <= b2)
            {
                Symbol2 = "Aples";
            }
            else if (noppa2.Randomice >= c1 && noppa2.Randomice <= c2)
            {
                Symbol2 = "Coins";
            }
            else if (noppa2.Randomice >= d1 && noppa2.Randomice <= d2)
            {
                Symbol2 = "Orange";
            }
            else if (noppa2.Randomice >= e1 && noppa2.Randomice <= e2)
            {
                Symbol2 = "Ace";
            }
            else if (noppa2.Randomice >= f1 && noppa2.Randomice <= f2)
            {
                Symbol2 = "Diamond";
            }
            else if (noppa2.Randomice >= g1 && noppa2.Randomice <= g2)
            {
                Symbol2 = "7";
            }
        }

        if (Symbol2 == "Berry")
        {
            Berry2.SetActive(true);
        }
        else
        {
            Berry2.SetActive(false);
        }

        if (Symbol2 == "Aples")
        {
            Apple2.SetActive(true);
        }
        else
        {
            Apple2.SetActive(false);
        }

        if (Symbol2 == "Coins")
        {
            Coin2.SetActive(true);
        }
        else
        {
            Coin2.SetActive(false);
        }

        if (Symbol2 == "Orange")
        {
            Orange2.SetActive(true);
        }
        else
        {
            Orange2.SetActive(false);
        }

        if (Symbol2 == "Diamond")
        {
            Diamond2.SetActive(true);
        }
        else
        {
            Diamond2.SetActive(false);
        }

        if (Symbol2 == "Ace")
        {
            Ace2.SetActive(true);
        }
        else
        {
            Ace2.SetActive(false);
        }

        if (Symbol2 == "7")
        {
            Seven2.SetActive(true);
        }
        else
        {
            Seven2.SetActive(false);
        }

        //if (gameObject.CompareTag("3"))
        {
            if (noppa3.Randomice >= a1 && noppa3.Randomice <= a2)
            {
                Symbol3 = "Berry";
            }
            else if (noppa3.Randomice >= b1 && noppa3.Randomice <= b2)
            {
                Symbol3 = "Aples";
            }
            else if (noppa3.Randomice >= c1 && noppa3.Randomice <= c2)
            {
                Symbol3 = "Coins";
            }
            else if (noppa3.Randomice >= d1 && noppa3.Randomice <= d2)
            {
                Symbol3 = "Orange";
            }
            else if (noppa3.Randomice >= e1 && noppa3.Randomice <= e2)
            {
                Symbol3 = "Ace";
            }
            else if (noppa3.Randomice >= f1 && noppa3.Randomice <= f2)
            {
                Symbol3 = "Diamond";
            }
            else if (noppa3.Randomice >= g1 && noppa3.Randomice <= g2)
            {
                Symbol3 = "7";
            }
        }

        if (Symbol3 == "Berry")
        {
            Berry3.SetActive(true);
        }
        else
        {
            Berry3.SetActive(false);
        }

        if (Symbol3 == "Aples")
        {
            Apple3.SetActive(true);
        }
        else
        {
            Apple3.SetActive(false);
        }

        if (Symbol3 == "Coins")
        {
            Coin3.SetActive(true);
        }
        else
        {
            Coin3.SetActive(false);
        }

        if (Symbol3 == "Orange")
        {
            Orange3.SetActive(true);
        }
        else
        {
            Orange3.SetActive(false);
        }

        if (Symbol3 == "Diamond")
        {
            Diamond3.SetActive(true);
        }
        else
        {
            Diamond3.SetActive(false);
        }

        if (Symbol3 == "Ace")
        {
            Ace3.SetActive(true);
        }
        else
        {
            Ace3.SetActive(false);
        }

        if (Symbol3 == "7")
        {
            Seven3.SetActive(true);
        }
        else
        {
            Seven3.SetActive(false);
        }

        //if (gameObject.CompareTag("4"))
        {
            if (noppa4.Randomice >= a1 && noppa4.Randomice <= a2)
            {
                Symbol4 = "Berry";
            }
            else if (noppa4.Randomice >= b1 && noppa4.Randomice <= b2)
            {
                Symbol4 = "Aples";
            }
            else if (noppa4.Randomice >= c1 && noppa4.Randomice <= c2)
            {
                Symbol4 = "Coins";
            }
            else if (noppa4.Randomice >= d1 && noppa4.Randomice <= d2)
            {
                Symbol4 = "Orange";
            }
            else if (noppa4.Randomice >= e1 && noppa4.Randomice <= e2)
            {
                Symbol4 = "Ace";
            }
            else if (noppa4.Randomice >= f1 && noppa4.Randomice <= f2)
            {
                Symbol4 = "Diamond";
            }
            else if (noppa4.Randomice >= g1 && noppa4.Randomice <= g2)
            {
                Symbol4 = "7";
            }
        }

        if (Symbol4 == "Berry")
        {
            Berry4.SetActive(true);
        }
        else
        {
            Berry4.SetActive(false);
        }

        if (Symbol4 == "Aples")
        {
            Apple4.SetActive(true);
        }
        else
        {
            Apple4.SetActive(false);
        }

        if (Symbol4 == "Coins")
        {
            Coin4.SetActive(true);
        }
        else
        {
            Coin4.SetActive(false);
        }

        if (Symbol4 == "Orange")
        {
            Orange4.SetActive(true);
        }
        else
        {
            Orange4.SetActive(false);
        }

        if (Symbol4 == "Diamond")
        {
            Diamond4.SetActive(true);
        }
        else
        {
            Diamond4.SetActive(false);
        }

        if (Symbol4 == "Ace")
        {
            Ace4.SetActive(true);
        }
        else
        {
            Ace4.SetActive(false);
        }

        if (Symbol4 == "7")
        {
            Seven4.SetActive(true);
        }
        else
        {
            Seven4.SetActive(false);
        }

        // if (gameObject.CompareTag("5"))
        {
            if (noppa5.Randomice >= a1 && noppa5.Randomice <= a2)
            {
                Symbol5 = "Berry";
            }
            else if (noppa5.Randomice >= b1 && noppa5.Randomice <= b2)
            {
                Symbol5 = "Aples";
            }
            else if (noppa5.Randomice >= c1 && noppa5.Randomice <= c2)
            {
                Symbol5 = "Coins";
            }
            else if (noppa5.Randomice >= d1 && noppa5.Randomice <= d2)
            {
                Symbol5 = "Orange";
            }
            else if (noppa5.Randomice >= e1 && noppa5.Randomice <= e2)
            {
                Symbol5 = "Ace";
            }
            else if (noppa5.Randomice >= f1 && noppa5.Randomice <= f2)
            {
                Symbol5 = "Diamond";
            }
            else if (noppa5.Randomice >= g1 && noppa5.Randomice <= g2)
            {
                Symbol5 = "7";
            }
        }

        if (Symbol5 == "Berry")
        {
            Berry5.SetActive(true);
        }
        else
        {
            Berry5.SetActive(false);
        }

        if (Symbol5 == "Aples")
        {
            Apple5.SetActive(true);
        }
        else
        {
            Apple5.SetActive(false);
        }

        if (Symbol5 == "Coins")
        {
            Coin5.SetActive(true);
        }
        else
        {
            Coin5.SetActive(false);
        }

        if (Symbol5 == "Orange")
        {
            Orange5.SetActive(true);
        }
        else
        {
            Orange5.SetActive(false);
        }

        if (Symbol5 == "Diamond")
        {
            Diamond5.SetActive(true);
        }
        else
        {
            Diamond5.SetActive(false);
        }

        if (Symbol5 == "Ace")
        {
            Ace5.SetActive(true);
        }
        else
        {
            Ace5.SetActive(false);
        }

        if (Symbol5 == "7")
        {
            Seven5.SetActive(true);
        }
        else
        {
            Seven5.SetActive(false);
        }

        //if (gameObject.CompareTag("6"))
        {
            if (noppa6.Randomice >= a1 && noppa6.Randomice <= a2)
            {
                Symbol6 = "Berry";
            }
            else if (noppa6.Randomice >= b1 && noppa6.Randomice <= b2)
            {
                Symbol6 = "Aples";
            }
            else if (noppa6.Randomice >= c1 && noppa6.Randomice <= c2)
            {
                Symbol6 = "Coins";
            }
            else if (noppa6.Randomice >= d1 && noppa6.Randomice <= d2)
            {
                Symbol6 = "Orange";
            }
            else if (noppa6.Randomice >= e1 && noppa6.Randomice <= e2)
            {
                Symbol6 = "Ace";
            }
            else if (noppa6.Randomice >= f1 && noppa6.Randomice <= f2)
            {
                Symbol6 = "Diamond";
            }
            else if (noppa6.Randomice >= g1 && noppa6.Randomice <= g2)
            {
                Symbol6 = "7";
            }
        }

        if (Symbol6 == "Berry")
        {
            Berry6.SetActive(true);
        }
        else
        {
            Berry6.SetActive(false);
        }

        if (Symbol6 == "Aples")
        {
            Apple6.SetActive(true);
        }
        else
        {
            Apple6.SetActive(false);
        }

        if (Symbol6 == "Coins")
        {
            Coin6.SetActive(true);
        }
        else
        {
            Coin6.SetActive(false);
        }

        if (Symbol6 == "Orange")
        {
            Orange6.SetActive(true);
        }
        else
        {
            Orange6.SetActive(false);
        }

        if (Symbol6 == "Diamond")
        {
            Diamond6.SetActive(true);
        }
        else
        {
            Diamond6.SetActive(false);
        }

        if (Symbol6 == "Ace")
        {
            Ace6.SetActive(true);
        }
        else
        {
            Ace6.SetActive(false);
        }

        if (Symbol6 == "7")
        {
            Seven6.SetActive(true);
        }
        else
        {
            Seven6.SetActive(false);
        }

        //if (gameObject.CompareTag("7"))
        {
            if (noppa7.Randomice >= a1 && noppa7.Randomice <= a2)
            {
                Symbol7 = "Berry";
            }
            else if (noppa7.Randomice >= b1 && noppa7.Randomice <= b2)
            {
                Symbol7 = "Aples";
            }
            else if (noppa7.Randomice >= c1 && noppa7.Randomice <= c2)
            {
                Symbol7 = "Coins";
            }
            else if (noppa7.Randomice >= d1 && noppa7.Randomice <= d2)
            {
                Symbol7 = "Orange";
            }
            else if (noppa7.Randomice >= e1 && noppa7.Randomice <= e2)
            {
                Symbol7 = "Ace";
            }
            else if (noppa7.Randomice >= f1 && noppa7.Randomice <= f2)
            {
                Symbol7 = "Diamond";
            }
            else if (noppa7.Randomice >= g1 && noppa7.Randomice <= g2)
            {
                Symbol7 = "7";
            }
        }

        if (Symbol7 == "Berry")
        {
            Berry7.SetActive(true);
        }
        else
        {
            Berry7.SetActive(false);
        }

        if (Symbol7 == "Aples")
        {
            Apple7.SetActive(true);
        }
        else
        {
            Apple7.SetActive(false);
        }

        if (Symbol7 == "Coins")
        {
            Coin7.SetActive(true);
        }
        else
        {
            Coin7.SetActive(false);
        }

        if (Symbol7 == "Orange")
        {
            Orange7.SetActive(true);
        }
        else
        {
            Orange7.SetActive(false);
        }

        if (Symbol7 == "Diamond")
        {
            Diamond7.SetActive(true);
        }
        else
        {
            Diamond7.SetActive(false);
        }

        if (Symbol7 == "Ace")
        {
            Ace7.SetActive(true);
        }
        else
        {
            Ace7.SetActive(false);
        }

        if (Symbol7 == "7")
        {
            Seven7.SetActive(true);
        }
        else
        {
            Seven7.SetActive(false);
        }

        //if (gameObject.CompareTag("8"))
        {
            if (noppa8.Randomice >= a1 && noppa8.Randomice <= a2)
            {
                Symbol8 = "Berry";
            }
            else if (noppa8.Randomice >= b1 && noppa8.Randomice <= b2)
            {
                Symbol8 = "Aples";
            }
            else if (noppa8.Randomice >= c1 && noppa8.Randomice <= c2)
            {
                Symbol8 = "Coins";
            }
            else if (noppa8.Randomice >= d1 && noppa8.Randomice <= d2)
            {
                Symbol8 = "Orange";
            }
            else if (noppa8.Randomice >= e1 && noppa8.Randomice <= e2)
            {
                Symbol8 = "Ace";
            }
            else if (noppa8.Randomice >= f1 && noppa8.Randomice <= f2)
            {
                Symbol8 = "Diamond";
            }
            else if (noppa8.Randomice >= g1 && noppa8.Randomice <= g2)
            {
                Symbol8 = "7";
            }
        }

        if (Symbol8 == "Berry")
        {
            Berry8.SetActive(true);
        }
        else
        {
            Berry8.SetActive(false);
        }

        if (Symbol8 == "Aples")
        {
            Apple8.SetActive(true);
        }
        else
        {
            Apple8.SetActive(false);
        }

        if (Symbol8 == "Coins")
        {
            Coin8.SetActive(true);
        }
        else
        {
            Coin8.SetActive(false);
        }

        if (Symbol8 == "Orange")
        {
            Orange8.SetActive(true);
        }
        else
        {
            Orange8.SetActive(false);
        }

        if (Symbol8 == "Diamond")
        {
            Diamond8.SetActive(true);
        }
        else
        {
            Diamond8.SetActive(false);
        }

        if (Symbol8 == "Ace")
        {
            Ace8.SetActive(true);
        }
        else
        {
            Ace8.SetActive(false);
        }

        if (Symbol8 == "7")
        {
            Seven8.SetActive(true);
        }
        else
        {
            Seven8.SetActive(false);
        }

        //if (gameObject.CompareTag("9"))
        {
            if (noppa9.Randomice >= a1 && noppa9.Randomice <= a2)
            {
                Symbol9 = "Berry";
            }
            else if (noppa9.Randomice >= b1 && noppa9.Randomice <= b2)
            {
                Symbol9 = "Aples";
            }
            else if (noppa9.Randomice >= c1 && noppa9.Randomice <= c2)
            {
                Symbol9 = "Coins";
            }
            else if (noppa9.Randomice >= d1 && noppa9.Randomice <= d2)
            {
                Symbol9 = "Orange";
            }
            else if (noppa9.Randomice >= e1 && noppa9.Randomice <= e2)
            {
                Symbol9 = "Ace";
            }
            else if (noppa9.Randomice >= f1 && noppa9.Randomice <= f2)
            {
                Symbol9 = "Diamond";
            }
            else if (noppa9.Randomice >= g1 && noppa9.Randomice <= g2)
            {
                Symbol9 = "7";
            }
        }

        if (Symbol9 == "Berry")
        {
            Berry9.SetActive(true);
        }
        else
        {
            Berry9.SetActive(false);
        }

        if (Symbol9 == "Aples")
        {
            Apple9.SetActive(true);
        }
        else
        {
            Apple9.SetActive(false);
        }

        if (Symbol9 == "Coins")
        {
            Coin9.SetActive(true);
        }
        else
        {
            Coin9.SetActive(false);
        }

        if (Symbol9 == "Orange")
        {
            Orange9.SetActive(true);
        }
        else
        {
            Orange9.SetActive(false);
        }

        if (Symbol9 == "Diamond")
        {
            Diamond9.SetActive(true);
        }
        else
        {
            Diamond9.SetActive(false);
        }

        if (Symbol9 == "Ace")
        {
            Ace9.SetActive(true);
        }
        else
        {
            Ace9.SetActive(false);
        }

        if (Symbol9 == "7")
        {
            Seven9.SetActive(true);
        }
        else
        {
            Seven9.SetActive(false);
        }
    }
}
