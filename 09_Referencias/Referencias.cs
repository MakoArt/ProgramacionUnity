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
    //Seguridad: Al pasar por valor, se crea una copia local de la variable.Esto significa que los cambios dentro de la funci�n no afectar�n la variable original fuera de ella.
    // Predecible: El comportamiento es m�s predecible, ya que no hay sorpresas en cuanto a modificaciones inesperadas.
    // Desventajas:
    //Overhead: Se crea una copia de la variable, lo que puede ser costoso en t�rminos de memoria y rendimiento.
    //Ineficiente para objetos grandes: Si la variable es un objeto grande, copiarlo puede ser ineficiente.




// Paso por referencia:
//Ventajas:
//Eficiencia: No se crea una copia; la funci�n trabaja directamente con la variable original.
//Modificaciones reflejadas: Los cambios dentro de la funci�n afectan directamente a la variable original.
//Desventajas:
//Menos seguro: Puede ser m�s dif�cil rastrear y predecir cambios en la variable original.
//Efectos secundarios inesperados: Si no se maneja correctamente, las modificaciones pueden afectar otras partes del c�digo.
//En resumen:

//Paso por valor es m�s seguro y predecible, pero puede ser costoso en t�rminos de rendimiento.
//Paso por referencia es m�s eficiente, pero requiere precauci�n para evitar efectos secundarios inesperados.
//La elecci�n depende de tus necesidades espec�ficas y del lenguaje de programaci�n que est�s utilizando.Por ejemplo:


    public void Suma(ref int numero)
    {
        numero = numero * 2;                                           
        Debug.Log(" VALOR DENTRO DE LA FUNCI�N : " + numero);
    }

    private void Start()
    {
        int numeroOriginal = 5; 
        Suma(ref numeroOriginal);
        Debug.Log(" VALOR FUERA DE LA FUNCI�N : " + numeroOriginal);

    }


    private void Update()
    {
        
    }

}
