using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerables : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] Renderer cubeRenderer;

     Vector3 init;

    public enum CubeState {NORMAL,ALTO,ANCHO,VERDE,ROJO}
    public CubeState cubeState;
   
    void Start()
    {
        cubeState = CubeState.NORMAL;
       init = cube.transform.localScale;
    }

    private void EstadoAlto() 
    {
        Debug.Log("El cubo esta en estado ALTO");
        cube.transform.localScale += new Vector3(0, 3, 0);
    }
    private void EstadoAncho()
    {
        Debug.Log("El cubo esta en estado ANCHO");
        cube.transform.localScale += new Vector3(3, 0, 0);
    }
    private void EstadoVerde()
    {
        cubeRenderer.material.color = Color.green;
    }
    private void EstadoRojo()
    {
        cubeRenderer.material.color = Color.red;
    }
    private void EstadoNormal()
    {
        cube.transform.localScale = init;
        cubeRenderer.material.color = Color.white;
    }




    public void ChangeStates()
    {
        switch (cubeState)
        {
            case CubeState.ALTO:
                EstadoAlto();
                break;
            case CubeState.ANCHO:
                EstadoAncho();
                break;
            case CubeState.VERDE:
                EstadoVerde();
                break;
            case CubeState.ROJO:
                EstadoRojo();
                break;
            case CubeState.NORMAL:
                EstadoNormal(); 
                break;
        }
    }


}
