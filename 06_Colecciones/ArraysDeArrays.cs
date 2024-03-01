using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysDeArrays : MonoBehaviour
{

    [SerializeField] GameObject cube;



    private Vector3 VectorFunction(int x, int y, int z)
    {
        return new Vector3(cube.transform.position.x + x, cube.transform.position.y + y, cube.transform.position.z + z);
    }




    void Start()
    {
        int[][] lista = new int[6][]
        {
            new int[10]{0,0,0,1,1,1,0,0,0,0},
            new int[10]{0,0,0,1,1,1,0,0,0,0},
            new int[10]{0,0,0,1,1,1,0,0,0,0},
            new int[10]{0,0,0,0,0,0,0,0,0,0},
            new int[10]{0,0,0,0,0,0,0,0,0,0},
            new int[10]{0,0,0,0,0,0,0,0,0,0}
        };

    

        for (int filas=0; filas<lista.Length; filas++)
        {
            for(int columnas = 0; columnas < lista[filas].Length; columnas++)
            {
                if (lista[filas][columnas] == 0)
                {
                   GameObject o= Instantiate(cube, VectorFunction(columnas, filas, 0), cube.transform.rotation);

                   o.GetComponent<Renderer>().material.color = Color.blue ;
                    
                  
                   
                }

                if (lista[filas][columnas] == 1)
                {
                    GameObject o = Instantiate(cube, VectorFunction(columnas, filas, 0), cube.transform.rotation);

                    o.GetComponent<Renderer>().material.color = Color.red;



                }


            }
        }



    }


}
