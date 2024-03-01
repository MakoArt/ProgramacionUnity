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
 
 
Un “puntero” es una dirección de memoria. Normalmente un puntero tendrá un tipo de datos asociado: por ejemplo, un
“puntero a entero” será una dirección de memoria en la que habrá almacenado (o podremos almacenar) un número entero.

El hecho de poder acceder directamente al contenido de ciertas posiciones de memoria da una mayor versatilidad a un programa, porque permite hacer casi cualquier cosa, pero a cambio de un riesgo de errores mucho mayor.

En lenguajes como C, es imprescindible utilizar punteros para poder crear estructuras dinámicas, pero en C# podemos “esquivarlos”, dado que tenemos varias estructuras dinámicas ya creadas como parte de las bibliotecas auxiliares que acompañan al lenguaje básico.

  int numero;  "numero" es un número entero 
int* posicion;  "posicion" es un "puntero a entero" (dirección de memoria en la que podremos guardar un entero) 
También es correcto escribir

int *posicion;  el asterisco en este caso lo ponemos pegado a la variable puntero 
El valor que guarda “posicion” es una dirección de memoria. Generalmente no podremos hacer cosas como posicion=5; porque nada nos garantiza que la posición 5 de la memoria esté disponible para que nosotros la usemos. Será más habitual que tomemos una dirección de memoria que ya contiene otro dato, o bien que le pidamos al compilador que nos reserve un espacio de memoria (más adelante veremos cómo).

Si queremos que “posicion” contenga la dirección de memoria que el compilador había reservado para la variable “numero”, lo haríamos usando el símbolo “&”, así:

  posicion = ? 
Como los punteros son “peligrosos” (es frecuente que den lugar a errores muy difíciles de encontrar), el compilador nos obliga a que le digamos que sabemos que esa zona de programa no es segura, usando la palabra “unsafe”:


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
        // Ésta es la parte insegura de "Main" 
        unsafe
        {
            // La función espera un puntero, así que le pasamos 
            // la dirección de memoria del entero: 
            Incrementar(&i);
        }
        // Y mostramos el resultado 
        Console.WriteLine(i);
    }
}
Podemos reservar espacio para una variable dinámica usando “stackalloc”. Por ejemplo, una forma alternativa de crear un array de enteros sería ésta:

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

Si aumentamos o disminuimos el valor de un puntero, cambiará la posición que representa ... pero no cambiará de uno en uno, sino que saltará a la siguiente posición capaz de almacenar un dato como el que corresponde a su tipo base. Por ejemplo, si un puntero a entero tiene como valor 40.000 y hacemos "puntero++", su dirección pasará a ser 40.004 (porque cada entero ocupa 4 bytes).

Fixed
C# cuenta con un "recolector de basura", que se encarga de liberar el espacio ocupado por variables que ya no se usan. Esto puede suponer algún problema cuando usamos variables dinámicas, porque estemos accediendo a una posición de memoria que el entorno de ejecución haya previsto que ya no necesitaríamos… y haya borrado.

Por eso, en ciertas ocasiones el compilador puede avisarnos de que algunas asignaciones son peligrosas y obligar a que usemos la palabra "fixed" para indicar al compilador que esa zona "no debe limpiarse automáticamente".

Esta palabra se usa antes de la declaración y asignación de la variable, y la zona de programa que queremos "bloquear" se indica entre llaves:

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

Como se ve en el programa anterior, en una zona "fixed" no se puede modificar el valor de esa variables; si lo intentamos recibiremos un mensaje de error que nos avisa de que esa variable es de "sólo lectura" (read-only). Por eso, para cambiarla, tendremos que empezar otra nueva zona "fixed".
 
 */