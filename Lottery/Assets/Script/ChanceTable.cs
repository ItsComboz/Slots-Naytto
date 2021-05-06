using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanceTable : MonoBehaviour
{
    public string Symbol;
    //   HingeJoint hinge = gameObject.GetComponent<HingeJoint>();
    private Roll_1 noppa;
    
    // Start is called before the first frame update
    void Start()
    {
        noppa = new Roll_1();    
    }
    
  
    // Update is called once per frame
    void Update()
    {
        Debug.Log(noppa.Randomice);
        
        if(noppa.Randomice <= 40 && noppa.Randomice >= 1)
        {
            Symbol = "Ace";
        }
        //*/
    }
}
