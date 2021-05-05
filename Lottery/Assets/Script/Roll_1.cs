using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Roll_1 : MonoBehaviour
{

    public int Random;

    // Start is called before the first frame update
    void Start()
    {
        

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

        int DeNumber = UnityEngine.Random.Range(0, 101);
        Random = DeNumber;

    }
}
 