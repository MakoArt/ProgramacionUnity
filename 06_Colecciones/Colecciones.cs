using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class Colecciones : MonoBehaviour
{
    int[] arrayInt;



    private void Awake()
    {
        arrayInt = new int[4]; 
    }


    private void Start()
    {
        arrayInt[0] = 34;
        arrayInt[1] = 4;
        arrayInt[2] = 344;
        arrayInt[3] = 3;


        arrayInt[2] = 23;
        Debug.Log(" La edad de la estatuta es de " + arrayInt[2]);


        //Recorro el array con un for **********************************

        //for (int i = 0; i < arrayInt.Length; i++)
        //{
        //    Debug.Log(" El elemento de la lista es el numero " + arrayInt[i] + " Y esta guardado en el indice : " + i);
        //}


        // Recorro el array con un foreach *****************************************

        //foreach (int numb in arrayInt)
        //{
        //    Debug.Log(" El elemento de la lista es el numero " + numb);
        //}

        //Recorrer el array con un while  ********************************************

        //int index = 0;

        //while (index < arrayInt.Length)
        //{
        //    Debug.Log("El elemento de la lista es el numero " + arrayInt[index] + " Y esta guardado en el indice: " + index);
        //    index++;

        //}


        ////Do while 


        //do
        //{
        //    Debug.Log("El elemento de la lista es el numero " + arrayInt[index] + " Y esta guardado en el indice: " + index);
        //    index++;

        //} while (index < arrayInt.Length);



    }

}

//ARRAYS 

//Caracteristicas de los arrays  
//empiezan con el indice 0 
//son estructuras estáticas que no pueden ser modificadas  no podemos añadir ni quitar datos  
//podemos modificar el valor de su contenido 
//las vamos  a recorrer con un foreach o con un for 


//arrays
//arrays de arrays
//arrays 2D 
//arrays 3D 
//Listas
//ArrayList 
//diccionarios

//Pilas 
//Colas 
//Tipos genericos 