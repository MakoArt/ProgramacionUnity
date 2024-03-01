using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    int number1 = 34;
    int number2 = 40;

    int age = 40;

    string nombre = "Vanessa";
    bool isPolice = true;


    public bool isPelirroja = true;
    public bool isGordibuena = true;

    int notes = 11;

    //Comparacion == !=  <  >  <=  >=           logicos   || && ! (or , and , not)
    void Start()
    {
        /*
        if (number1 != number2)
        {
            Debug.Log("El numero 1 es distinto al numero 2");
        }
        else
        {
            Debug.Log("Los números son iguales");
        }

        */

     

      string mensaje =  number1 != number2 ? "El numero1 es distinto al numero2" : " El numero 1 es igual a numero 2";
      Debug.Log(mensaje);

        //if(age >= 14 && age < 18)
        //{
        //    Debug.Log(" Solo estan  habilitados para acceder a la sala 1 ");
        //}
        //else if(age >=18 && age <=30)
        //{
        //    Debug.Log("Estan habilitados a acceder a la sala 2 ");
        //}
        //else if(age >30 )
        //{
        //    Debug.Log("Estan habilitados a acceder a la sala 3 ");
        //}
        //else
        //{
        //    Debug.Log("No estan habilitados para entrar en ninguna sala");
        //}



        //if (nombre != "Vanessa" && !isPolice)
        //{
        //    Debug.Log("Esa no es la mujer que vi anoche en la discoteca");
        //}
        //else if (nombre != "Vanessa" && isPolice)
        //{
        //    Debug.Log("Esa no es la mujer que vi en la discoteca anoche");
        //}
        //else if (nombre == "Vanessa" && !isPolice)
        //{
        //    Debug.Log("Esa no es la mujer que vi en la discoteca anoche");
        //}
        //else
        //{
        //    Debug.Log(" Si es esa la que estoy buscando ");
        //}


        switch (notes)
        {
            case 0:
                Debug.Log(" No has acertado ninguna ");

                break;
            case 1:
                Debug.Log("has hacertado  1 ");
                break;
            case 2:
                Debug.Log(" has hacertado  2");
                break;
            case 3:
                Debug.Log("has hacertado  3 ");
                
                break;
            case 4:
                Debug.Log(" has hacertado  4");
                break;
            case 5:
                Debug.Log(" has hacertado  5 ");
                break;
            case 6:
                Debug.Log(" has hacertado  6");
                break;
            case 7:
                Debug.Log(" has hacertado  7 ");
                break;
            case 8:
                Debug.Log(" has hacertado  8 ");
                break;
            case 9:
                Debug.Log(" has hacertado  9 ");
                break;
            case 10:
                Debug.Log(" has hacertado  10 ");
                break;
            default:
                Debug.Log(" imposible que hayas acertado más de 10 el máximo son 10");
                break;
        }

             
    }

    // Update is called once per frame
    void Update()
    {  
        if(Input.GetKeyDown(KeyCode.Space)) 
        {

            if (isGordibuena && isPelirroja) Debug.Log(" Que rica que esta me voy a casar con ella");
            if (!isGordibuena && isPelirroja) Debug.Log(" Que atractiva le voy a dar una oportunidad ");
            if (isGordibuena && !isPelirroja) Debug.Log(" Madre mia , como me pone !!");
            if (!isGordibuena && !isPelirroja) Debug.Log(" No eres mi tipo , lo siento ");

        }


    }


}
