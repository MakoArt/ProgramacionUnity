using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversion : MonoBehaviour
{
    double doubleVariable = 34.5434;
    int intVariable;

    void Start()
    {
        // CASTING   
        //conversión explicita en la que perdemos datos decimales  
        //intVariable = (int)doubleVariable;
        //Debug.Log("El tipo de dato es : " + intVariable.GetType());

        //coversión implicita de menos a mas datos 
        //int numero = 23456;
        //long num = numero; 
        //Debug.Log(num.GetType());   


        //PARSING O PARSEO DE DATOS  

        string cadena = "345435"; 

        int parsearAEntero=Int32.Parse(cadena);
        Debug.Log(parsearAEntero.GetType());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
