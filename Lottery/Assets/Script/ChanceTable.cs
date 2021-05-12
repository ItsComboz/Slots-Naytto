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

    private Roll_1 noppa;

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
        noppa = gameObject.GetComponent<Roll_1>();    
    }
    
  
    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("1"))
        {
            if (noppa.Randomice >= a1 && noppa.Randomice <= a2)
            {
                Symbol1 = "Berry";
            }else if (noppa.Randomice >= b1 && noppa.Randomice <= b2)
            {
                Symbol1 = "Aples";
            }
            else if (noppa.Randomice >= c1 && noppa.Randomice <= c2)
            {
                Symbol1 = "Coins";
            }
            else if (noppa.Randomice >= d1 && noppa.Randomice <= d2)
            {
                Symbol1 = "Orange";
            }
            else if (noppa.Randomice >= e1 && noppa.Randomice <= e2)
            {
                Symbol1 = "Ace";
            }
            else if (noppa.Randomice >= f1 && noppa.Randomice <= f2)
            {
                Symbol1 = "Diamond";
            }
            else if (noppa.Randomice >= g1 && noppa.Randomice <= g2)
            {
                Symbol1 = "7";
            }
        }

        if (gameObject.CompareTag("2"))
        {
            if (noppa.Randomice >= a1 && noppa.Randomice <= a2)
            {
                Symbol2 = "Berry";
            }
            else if (noppa.Randomice >= b1 && noppa.Randomice <= b2)
            {
                Symbol2 = "Aples";
            }
            else if (noppa.Randomice >= c1 && noppa.Randomice <= c2)
            {
                Symbol2 = "Coins";
            }
            else if (noppa.Randomice >= d1 && noppa.Randomice <= d2)
            {
                Symbol2 = "Orange";
            }
            else if (noppa.Randomice >= e1 && noppa.Randomice <= e2)
            {
                Symbol2 = "Ace";
            }
            else if (noppa.Randomice >= f1 && noppa.Randomice <= f2)
            {
                Symbol2 = "Diamond";
            }
            else if (noppa.Randomice >= g1 && noppa.Randomice <= g2)
            {
                Symbol2 = "7";
            }
        }

        if (gameObject.CompareTag("3"))
        {
            if (noppa.Randomice >= a1 && noppa.Randomice <= a2)
            {
                Symbol3 = "Berry";
            }
            else if (noppa.Randomice >= b1 && noppa.Randomice <= b2)
            {
                Symbol3 = "Aples";
            }
            else if (noppa.Randomice >= c1 && noppa.Randomice <= c2)
            {
                Symbol3 = "Coins";
            }
            else if (noppa.Randomice >= d1 && noppa.Randomice <= d2)
            {
                Symbol3 = "Orange";
            }
            else if (noppa.Randomice >= e1 && noppa.Randomice <= e2)
            {
                Symbol3 = "Ace";
            }
            else if (noppa.Randomice >= f1 && noppa.Randomice <= f2)
            {
                Symbol3 = "Diamond";
            }
            else if (noppa.Randomice >= g1 && noppa.Randomice <= g2)
            {
                Symbol3 = "7";
            }
        }

        if (gameObject.CompareTag("4"))
        {
            if (noppa.Randomice >= a1 && noppa.Randomice <= a2)
            {
                Symbol4 = "Berry";
            }
            else if (noppa.Randomice >= b1 && noppa.Randomice <= b2)
            {
                Symbol4 = "Aples";
            }
            else if (noppa.Randomice >= c1 && noppa.Randomice <= c2)
            {
                Symbol4 = "Coins";
            }
            else if (noppa.Randomice >= d1 && noppa.Randomice <= d2)
            {
                Symbol4 = "Orange";
            }
            else if (noppa.Randomice >= e1 && noppa.Randomice <= e2)
            {
                Symbol4 = "Ace";
            }
            else if (noppa.Randomice >= f1 && noppa.Randomice <= f2)
            {
                Symbol4 = "Diamond";
            }
            else if (noppa.Randomice >= g1 && noppa.Randomice <= g2)
            {
                Symbol4 = "7";
            }
        }

        if (gameObject.CompareTag("5"))
        {
            if (noppa.Randomice >= a1 && noppa.Randomice <= a2)
            {
                Symbol5 = "Berry";
            }
            else if (noppa.Randomice >= b1 && noppa.Randomice <= b2)
            {
                Symbol5 = "Aples";
            }
            else if (noppa.Randomice >= c1 && noppa.Randomice <= c2)
            {
                Symbol5 = "Coins";
            }
            else if (noppa.Randomice >= d1 && noppa.Randomice <= d2)
            {
                Symbol5 = "Orange";
            }
            else if (noppa.Randomice >= e1 && noppa.Randomice <= e2)
            {
                Symbol5 = "Ace";
            }
            else if (noppa.Randomice >= f1 && noppa.Randomice <= f2)
            {
                Symbol5 = "Diamond";
            }
            else if (noppa.Randomice >= g1 && noppa.Randomice <= g2)
            {
                Symbol5 = "7";
            }
        }

        if (gameObject.CompareTag("6"))
        {
            if (noppa.Randomice >= a1 && noppa.Randomice <= a2)
            {
                Symbol6 = "Berry";
            }
            else if (noppa.Randomice >= b1 && noppa.Randomice <= b2)
            {
                Symbol6 = "Aples";
            }
            else if (noppa.Randomice >= c1 && noppa.Randomice <= c2)
            {
                Symbol6 = "Coins";
            }
            else if (noppa.Randomice >= d1 && noppa.Randomice <= d2)
            {
                Symbol6 = "Orange";
            }
            else if (noppa.Randomice >= e1 && noppa.Randomice <= e2)
            {
                Symbol6 = "Ace";
            }
            else if (noppa.Randomice >= f1 && noppa.Randomice <= f2)
            {
                Symbol6 = "Diamond";
            }
            else if (noppa.Randomice >= g1 && noppa.Randomice <= g2)
            {
                Symbol6 = "7";
            }
        }

        if (gameObject.CompareTag("7"))
        {
            if (noppa.Randomice >= a1 && noppa.Randomice <= a2)
            {
                Symbol7 = "Berry";
            }
            else if (noppa.Randomice >= b1 && noppa.Randomice <= b2)
            {
                Symbol7 = "Aples";
            }
            else if (noppa.Randomice >= c1 && noppa.Randomice <= c2)
            {
                Symbol7 = "Coins";
            }
            else if (noppa.Randomice >= d1 && noppa.Randomice <= d2)
            {
                Symbol7 = "Orange";
            }
            else if (noppa.Randomice >= e1 && noppa.Randomice <= e2)
            {
                Symbol7 = "Ace";
            }
            else if (noppa.Randomice >= f1 && noppa.Randomice <= f2)
            {
                Symbol7 = "Diamond";
            }
            else if (noppa.Randomice >= g1 && noppa.Randomice <= g2)
            {
                Symbol7 = "7";
            }
        }

        if (gameObject.CompareTag("8"))
        {
            if (noppa.Randomice >= a1 && noppa.Randomice <= a2)
            {
                Symbol8 = "Berry";
            }
            else if (noppa.Randomice >= b1 && noppa.Randomice <= b2)
            {
                Symbol8 = "Aples";
            }
            else if (noppa.Randomice >= c1 && noppa.Randomice <= c2)
            {
                Symbol8 = "Coins";
            }
            else if (noppa.Randomice >= d1 && noppa.Randomice <= d2)
            {
                Symbol8 = "Orange";
            }
            else if (noppa.Randomice >= e1 && noppa.Randomice <= e2)
            {
                Symbol8 = "Ace";
            }
            else if (noppa.Randomice >= f1 && noppa.Randomice <= f2)
            {
                Symbol8 = "Diamond";
            }
            else if (noppa.Randomice >= g1 && noppa.Randomice <= g2)
            {
                Symbol8 = "7";
            }
        }

        if (gameObject.CompareTag("9"))
        {
            if (noppa.Randomice >= a1 && noppa.Randomice <= a2)
            {
                Symbol9 = "Berry";
            }
            else if (noppa.Randomice >= b1 && noppa.Randomice <= b2)
            {
                Symbol9 = "Aples";
            }
            else if (noppa.Randomice >= c1 && noppa.Randomice <= c2)
            {
                Symbol9 = "Coins";
            }
            else if (noppa.Randomice >= d1 && noppa.Randomice <= d2)
            {
                Symbol9 = "Orange";
            }
            else if (noppa.Randomice >= e1 && noppa.Randomice <= e2)
            {
                Symbol9 = "Ace";
            }
            else if (noppa.Randomice >= f1 && noppa.Randomice <= f2)
            {
                Symbol9 = "Diamond";
            }
            else if (noppa.Randomice >= g1 && noppa.Randomice <= g2)
            {
                Symbol9 = "7";
            }
        }
    }
}
