using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventos : MonoBehaviour
{
    [SerializeField] List<Renderer> cubeRenderer;
    [SerializeField] Ball ball;
    [SerializeField] GameObject cube;


    private void changeColor()
    {
       for(int i = 0; i < cubeRenderer.Count; i++)
        {
            cubeRenderer[i].material.color = Color.green;
        }
    }

    private void largeCube()
    {
        cube.transform.localScale += new Vector3(0, 3, 0);
    }

    void Start()
    {
        ball.choque += changeColor;
        ball.choque += largeCube;
    }

    private void OnDisable()
    {
        ball.choque -= changeColor;
        ball.choque -= largeCube;
    }
}
