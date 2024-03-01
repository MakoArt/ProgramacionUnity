using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Concatenacion : MonoBehaviour
{
    private string saludo = "";
    private string nombre = "";
    private int age = 0;
    private int points = 0;

    private string frase = "";
 
    void Start()
    {
        age = 24;
        nombre = " Pedro ";
        saludo = $" Buenas tardes  mi nombre es {nombre} y mi edad es {age}";
        points = 34;

        //  frase = saludo + nombre + " y tengo " + age + " años ";

   
        Debug.Log(saludo);

    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
           
            //age = age + 1;
            age += 1;
            // frase = saludo + nombre + " y tengo " + age + " años ";
            nombre = " Javier ";
            saludo = $" Buenas tardes  mi nombre es {nombre} y mi edad es {age} ";
       
            Debug.Log(saludo);
        }
    }
}
