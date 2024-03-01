using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genericos2 : MonoBehaviour
{
   
    void Start()
    {
        Genericos<string> claseString= new Genericos<string>(); 
        Genericos<int> claseEnteros= new Genericos<int>();

        Debug.Log(claseString.ValuesList("string","Fusil","Espada"));

         

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
