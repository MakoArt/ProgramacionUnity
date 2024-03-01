using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays2DArrays3D : MonoBehaviour
{
    int[,] array = new int[3, 3]
    {
         {5,0,0 },
         {5,6,0 },
         {0,0,0 }
    };


    int[,,] array3D = new int[2, 3,3]
    {
        {
            {5,5,5 },
            {5,5,5 },
            {5,5,5 }
        },


         {
             {0,0,0 },
             {0,0,0 },
             {0,0,0 }
         },


    };


    void Start()
    {

        //for(int i = 0; i < array.GetLength(0); i++)
        //{
        //    for (int j = 0; j < array.GetLength(1); j++)
        //    {
        //        Debug.Log(array[i,j]);
        //    }
        //}

        // Debug.Log(array[1,2]);

         
        for(int X = 0; X < array3D.GetLength(0); X++)
        {
            for (int Y = 0; Y < array3D.GetLength(1); Y++)
            {
                Debug.Log("Estamos recorriendo el array 0 " + array3D[0, X, Y]);
            }
        }



        for (int X = 0; X < array3D.GetLength(0); X++)
        {
            for (int Y = 0; Y < array3D.GetLength(1); Y++)
            {
                Debug.Log("Estamos recorriendo el array 1 " + array3D[1, X, Y]);
            }
        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
