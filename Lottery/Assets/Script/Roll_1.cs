using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Roll_1 : MonoBehaviour
{

    public int Randomice;

    // Start is called before the first frame update
    void Start()
    {

        int DeNumber = UnityEngine.Random.Range(1, 101);
        Randomice = DeNumber;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateNumbers();
        }

    }

    private void GenerateNumbers()
    {

        int DeNumber = UnityEngine.Random.Range(1, 101);
        Randomice = DeNumber;

    }
}
 