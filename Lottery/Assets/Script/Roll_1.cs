using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Roll_1 : MonoBehaviour
{

    public int Randomice;

    //private ScoreCount Score;
   

    public ChanceTable chance;

    // Start is called before the first frame update
    void Start()
    {

        int DeNumber = UnityEngine.Random.Range(1, 101);
        Randomice = DeNumber;
        //chance = GetComponent<ChanceTable>();

    }

    // Update is called once per frame
    void Update()
    {

        

    }

    public void GenerateNumbers()
    {

        int DeNumber = UnityEngine.Random.Range(1, 101);
        Randomice = DeNumber;

    }
}
 