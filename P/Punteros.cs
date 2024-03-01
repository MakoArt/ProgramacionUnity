using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Punteros : MonoBehaviour
{
  
     void Start()
    {
        unsafe
        {
            int valor = 5;

            //creo puntero y hago que apunte a la direccion de valor guarda la direccion de valor
            int* p = &valor;
            Debug.Log(*p);
          
            //Cambiamos el valor 
            *p = 67;

            Debug.Log(*p);
            Debug.Log(valor);

            //arrays 
            int* datos = stackalloc int[3]; 
        }

        //invocamos el metodo que usa apuntadores 

        int a = 45;
        unsafe { Saludo(&a); }

        
       

        
        

    }
    unsafe public static void Saludo(int* palabra)
    {
        Debug.Log("Hola que tal " + *palabra);
    }

    void Update()
    {
        
    }
}



/*
 
 
Un �puntero� es una direcci�n de memoria. Normalmente un puntero tendr� un tipo de datos asociado: por ejemplo, un
�puntero a entero� ser� una direcci�n de memoria en la que habr� almacenado (o podremos almacenar) un n�mero entero.

El hecho de poder acceder directamente al contenido de ciertas posiciones de memoria da una mayor versatilidad a un programa, porque permite hacer casi cualquier cosa, pero a cambio de un riesgo de errores mucho mayor.

En lenguajes como C, es imprescindible utilizar punteros para poder crear estructuras din�micas, pero en C# podemos �esquivarlos�, dado que tenemos varias estructuras din�micas ya creadas como parte de las bibliotecas auxiliares que acompa�an al lenguaje b�sico.

  int numero;  "numero" es un n�mero entero 
int* posicion;  "posicion" es un "puntero a entero" (direcci�n de memoria en la que podremos guardar un entero) 
Tambi�n es correcto escribir

int *posicion;  el asterisco en este caso lo ponemos pegado a la variable puntero 
El valor que guarda �posicion� es una direcci�n de memoria. Generalmente no podremos hacer cosas como posicion=5; porque nada nos garantiza que la posici�n 5 de la memoria est� disponible para que nosotros la usemos. Ser� m�s habitual que tomemos una direcci�n de memoria que ya contiene otro dato, o bien que le pidamos al compilador que nos reserve un espacio de memoria (m�s adelante veremos c�mo).

Si queremos que �posicion� contenga la direcci�n de memoria que el compilador hab�a reservado para la variable �numero�, lo har�amos usando el s�mbolo �&�, as�:

  posicion = ? 
Como los punteros son �peligrosos� (es frecuente que den lugar a errores muy dif�ciles de encontrar), el compilador nos obliga a que le digamos que sabemos que esa zona de programa no es segura, usando la palabra �unsafe�:


  unsafe static void pruebaPunteros()
{
    ... 
using System;
public class ejemploUnsafe2
{

    public unsafe static void Incrementar(int* p)
    {
        //Incrementamos el entero "apuntado" por p 
        *p = *p + 1;
    }

    public static void Main()
    {
        int i = 1;
        // �sta es la parte insegura de "Main" 
        unsafe
        {
            // La funci�n espera un puntero, as� que le pasamos 
            // la direcci�n de memoria del entero: 
            Incrementar(&i);
        }
        // Y mostramos el resultado 
        Console.WriteLine(i);
    }
}
Podemos reservar espacio para una variable din�mica usando �stackalloc�. Por ejemplo, una forma alternativa de crear un array de enteros ser�a �sta:

using System; 
public class EjemploUnsafe3
{
    public unsafe static void Main()
    {
        const int tamanyoArray = 5;
        int* datos = stackalloc int[tamanyoArray];

        // Rellenamos el array 
        for (int i = 0; i < tamanyoArray; i++)
        {
            datos[i] = i * 10;
        }

        // Mostramos el array 
        for (int i = 0; i < tamanyoArray; i++)
        {
            Console.WriteLine(datos[i]);
        }
    }
}

Si aumentamos o disminuimos el valor de un puntero, cambiar� la posici�n que representa ... pero no cambiar� de uno en uno, sino que saltar� a la siguiente posici�n capaz de almacenar un dato como el que corresponde a su tipo base. Por ejemplo, si un puntero a entero tiene como valor 40.000 y hacemos "puntero++", su direcci�n pasar� a ser 40.004 (porque cada entero ocupa 4 bytes).

Fixed
C# cuenta con un "recolector de basura", que se encarga de liberar el espacio ocupado por variables que ya no se usan. Esto puede suponer alg�n problema cuando usamos variables din�micas, porque estemos accediendo a una posici�n de memoria que el entorno de ejecuci�n haya previsto que ya no necesitar�amos� y haya borrado.

Por eso, en ciertas ocasiones el compilador puede avisarnos de que algunas asignaciones son peligrosas y obligar a que usemos la palabra "fixed" para indicar al compilador que esa zona "no debe limpiarse autom�ticamente".

Esta palabra se usa antes de la declaraci�n y asignaci�n de la variable, y la zona de programa que queremos "bloquear" se indica entre llaves:

using System;  
public class EjemploUnsafe5
{

    public unsafe static void Main()
    {
        int[] datos = { 10, 20, 30 };

        Console.WriteLine("Leyendo el segundo dato...");
        fixed (int* posicionDato = &datos[1])
        {
            Console.WriteLine("En posicionDato hay {0}", *posicionDato);
        }

        Console.WriteLine("Leyendo el primer dato...");
        fixed (int* posicionDato = datos)
        {
            Console.WriteLine("Ahora en posicionDato hay {0}", *posicionDato);
        }
    }
}

Como se ve en el programa anterior, en una zona "fixed" no se puede modificar el valor de esa variables; si lo intentamos recibiremos un mensaje de error que nos avisa de que esa variable es de "s�lo lectura" (read-only). Por eso, para cambiarla, tendremos que empezar otra nueva zona "fixed".
 
 */