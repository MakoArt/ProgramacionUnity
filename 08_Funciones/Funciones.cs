using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour
{
    [SerializeField] Renderer cube;
    
    //Function simple 
    public void Saludo()
    {
        Debug.Log("Hola que tal");
    }
    //Funcion con parametros  
    public void SaludoPersonalizado(string nombre,int edad)
    {
        Debug.Log("Hola que tal " + nombre + " ¿Tu edad es " + edad + " ? ");
    }
    //Funcion con parametros opcionales  
    public void GetData(string nombre, int edad,int dni,int numHijos=0)
    {
        Debug.Log(" Nombre : " + nombre + " Edad : " + edad + " DNI : " + dni + " Hijos : " + numHijos);
    }
    //Funcion que nos devuelve un resultado o funciones con retorno  

    public float CalculaNumero(float numero1 , float numero2)
    {
        return numero1 * numero2;
    }
    //Ejemplo de funcion que cambia el color de un cubo 

    private void ChangeColor(Color32 color)
    {
     
        cube.material.color = color;
    }

    //Funciones Lambda  

    void GetSaludo(string frase) => Debug.Log(frase);
    float GetResult(float num1, float num2) => num1 * num2;



    private void Start()
    {
        //Saludo();
        //SaludoPersonalizado("Juan", 23);
        //SaludoPersonalizado("Mario", 34);
        //SaludoPersonalizado("Vanessa", 40);
        GetData("Julia", 34, 34432345);

        Debug.Log(CalculaNumero(4, 5) * 2);

        GetSaludo(" Hola saludos desde una función lambda ");

        Debug.Log(GetResult(2,2) * 2);
     
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            ChangeColor(new Color32(34, 230, 35, 1));
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            ChangeColor(new Color32(200, 20, 35, 1));
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeColor(new Color32(100, 10, 15, 1));
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            ChangeColor(new Color32(34, 130, 35, 1));
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            ChangeColor(new Color32(50, 20, 35, 1));
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            ChangeColor(new Color32(100, 70, 15, 1));
        }
    }
}
