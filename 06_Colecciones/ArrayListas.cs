using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListas : MonoBehaviour
{ 
    List<int> list = new List<int>(); 
    ArrayList peterData = new ArrayList();

    //nombre,edad,profesion,fuerza,velocidad
    private void Start()
    {
        peterData.Add("Peter");
        peterData.Add(34);
        peterData.Add("Carpintero");
        peterData.Add(20.4f);
        peterData.Add(10.4f);

        for(int i = 0; i < peterData.Count; i++)
        {
            Debug.Log(peterData[i]);


        }

       

    }

}
