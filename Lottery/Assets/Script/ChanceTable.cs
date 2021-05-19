using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Start()
    {
    }
    
  
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
    }
}
