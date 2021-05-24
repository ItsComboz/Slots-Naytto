using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreCount : MonoBehaviour
{
    public int Score = 0;
    [SerializeField]
    TextMeshPro TextPro;

    // Score Ammmounts
    public int Berrys = 20;
    public int Apples = 30;
    public int Oranges = 40;
    public int Coins = 60;
    public int Aces = 100;
    public int Diamonds = 120;
    public int Sevens = 150;


    public void Update()
    {
        TextPro.text = Score.ToString();
    }

    public void CountScore(ChanceTable Symbs)
    {

        if (Symbs.Symbol1 == Symbs.Symbol2 && Symbs.Symbol2 == Symbs.Symbol3)
        {
            if (Symbs.Symbol1 == "Berry")
            {
                Score = Score + Berrys;
            }
            if (Symbs.Symbol1 == "Aples")
            {
                Score = Score + Apples;
            }
            if (Symbs.Symbol1 == "Coins")
            {
                Score = Score + Coins;
            }
            if (Symbs.Symbol1 == "Orange")
            {
                Score = Score + Oranges;
            }
            if (Symbs.Symbol1 == "Ace")
            {
                Score = Score + Aces;
            }
            if (Symbs.Symbol1 == "Diamond")
            {
                Score = Score + Diamonds;
            }
            if (Symbs.Symbol1 == "7")
            {
                Score = Score + Sevens;
            }
        }

        if (Symbs.Symbol4 == Symbs.Symbol5 && Symbs.Symbol5 == Symbs.Symbol6)
        {
            if (Symbs.Symbol4 == "Berry")
            {
                Score = Score + Berrys;
            }
            if (Symbs.Symbol4 == "Aples")
            {
                Score = Score + Apples;
            }
            if (Symbs.Symbol4 == "Coins")
            {
                Score = Score + Coins;
            }
            if (Symbs.Symbol4 == "Orange")
            {
                Score = Score + Oranges;
            }
            if (Symbs.Symbol4 == "Ace")
            {
                Score = Score + Aces;
            }
            if (Symbs.Symbol4 == "Diamond")
            {
                Score = Score + Diamonds;
            }
            if (Symbs.Symbol4 == "7")
            {
                Score = Score + Sevens;
            }
        }

        if (Symbs.Symbol7 == Symbs.Symbol8 && Symbs.Symbol8 == Symbs.Symbol9)
        {
            if (Symbs.Symbol7 == "Berry")
            {
                Score = Score + Berrys;
            }
            if (Symbs.Symbol7 == "Aples")
            {
                Score = Score + Apples;
            }
            if (Symbs.Symbol7 == "Coins")
            {
                Score = Score + Coins;
            }
            if (Symbs.Symbol7 == "Orange")
            {
                Score = Score + Oranges;
            }
            if (Symbs.Symbol7 == "Ace")
            {
                Score = Score + Aces;
            }
            if (Symbs.Symbol7 == "Diamond")
            {
                Score = Score + Diamonds;
            }
            if (Symbs.Symbol7 == "7")
            {
                Score = Score + Sevens;
            }
        }

        if (Symbs.Symbol1 == Symbs.Symbol5 && Symbs.Symbol5 == Symbs.Symbol9)
        {
            if (Symbs.Symbol1 == "Berry")
            {
                Score = Score + Berrys;
            }
            if (Symbs.Symbol1 == "Aples")
            {
                Score = Score + Apples;
            }
            if (Symbs.Symbol1 == "Coins")
            {
                Score = Score + Coins;
            }
            if (Symbs.Symbol1 == "Orange")
            {
                Score = Score + Oranges;
            }
            if (Symbs.Symbol1 == "Ace")
            {
                Score = Score + Aces;
            }
            if (Symbs.Symbol1 == "Diamond")
            {
                Score = Score + Diamonds;
            }
            if (Symbs.Symbol1 == "7")
            {
                Score = Score + Sevens;
            }
        }

        if (Symbs.Symbol7 == Symbs.Symbol5 && Symbs.Symbol5 == Symbs.Symbol3)
        {
            if (Symbs.Symbol1 == "Berry")
            {
                Score = Score + Berrys;
            }
            if (Symbs.Symbol1 == "Aples")
            {
                Score = Score + Apples;
            }
            if (Symbs.Symbol1 == "Coins")
            {
                Score = Score + Coins;
            }
            if (Symbs.Symbol1 == "Orange")
            {
                Score = Score + Oranges;
            }
            if (Symbs.Symbol1 == "Ace")
            {
                Score = Score + Aces;
            }
            if (Symbs.Symbol1 == "Diamond")
            {
                Score = Score + Diamonds;
            }
            if (Symbs.Symbol1 == "7")
            {
                Score = Score + Sevens;
            }
        }
    }

}
