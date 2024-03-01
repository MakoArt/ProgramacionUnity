using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColasPilas : MonoBehaviour
{

    // COLAS (FIFO) (FIRST IN FIRST OUT primero que entra primero que sale) 
    // guardan datos al final de la cola y se llama encolar 
    // desencolar es quitar el primer elemento de la cola  
    // using System.Collection.Generic;
    // nos permiten recuperar datos en el orden de guardado  
    //.count par contar 


    ////  PILAS (LIFO) (ultimo que entra primero que sale)**********************************************
    //  guradar datos al final de la cola encolar
    //  desencolar, quitar el primer elemento de la cola
    //  using System.Collection.Generic; 
    //  nos permiten recuperar los datos en el mismo orden de guardado   
    //  Cola.count pra contar 


   // Queue<string> queue = new Queue<string>();
    Stack<string> stack = new Stack<string>();


    void Start()
    {
     //queue.Enqueue("Primer Comensal");
     //queue.Enqueue("Segundo Comensal");
     //queue.Enqueue("Tercer Comensal");

       stack.Push("Primer Plato");
       stack.Push("Segundo Plato");
       stack.Push("Tercer Plato");


        //Debug.Log(queue.Count);

        foreach (string plato in stack)
        {
            Debug.Log(plato);
  
        }
        Debug.Log("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        Debug.Log("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        Debug.Log("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
    }


     public void EliminarPersona()
    {
       
            stack.Pop();
            //queue.Dequeue();

            foreach (string stack in stack)
            {
                Debug.Log(stack);
            }
        

    }


}
