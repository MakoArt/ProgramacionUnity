using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Search;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEditor.ShaderData;
using static UnityEngine.EventSystems.EventTrigger;
using static UnityEngine.UI.Image;
public class Referencias : MonoBehaviour
{

    // PASO DE DATOS POR VALOR O REFERENCIA  

    //    Paso por valor:
    //Ventajas:
    //Seguridad: Al pasar por valor, se crea una copia local de la variable.Esto significa que los cambios dentro de la función no afectarán la variable original fuera de ella.
    // Predecible: El comportamiento es más predecible, ya que no hay sorpresas en cuanto a modificaciones inesperadas.
    // Desventajas:
    //Overhead: Se crea una copia de la variable, lo que puede ser costoso en términos de memoria y rendimiento.
    //Ineficiente para objetos grandes: Si la variable es un objeto grande, copiarlo puede ser ineficiente.




// Paso por referencia:
//Ventajas:
//Eficiencia: No se crea una copia; la función trabaja directamente con la variable original.
//Modificaciones reflejadas: Los cambios dentro de la función afectan directamente a la variable original.
//Desventajas:
//Menos seguro: Puede ser más difícil rastrear y predecir cambios en la variable original.
//Efectos secundarios inesperados: Si no se maneja correctamente, las modificaciones pueden afectar otras partes del código.
//En resumen:

//Paso por valor es más seguro y predecible, pero puede ser costoso en términos de rendimiento.
//Paso por referencia es más eficiente, pero requiere precaución para evitar efectos secundarios inesperados.
//La elección depende de tus necesidades específicas y del lenguaje de programación que estés utilizando.Por ejemplo:


    public void Suma(ref int numero)
    {
        numero = numero * 2;                                           
        Debug.Log(" VALOR DENTRO DE LA FUNCIÓN : " + numero);
    }

    private void Start()
    {
        int numeroOriginal = 5; 
        Suma(ref numeroOriginal);
        Debug.Log(" VALOR FUERA DE LA FUNCIÓN : " + numeroOriginal);

    }


    private void Update()
    {
        
    }

}
