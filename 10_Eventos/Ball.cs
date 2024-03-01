using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public delegate void Choque();
    public event Choque choque; 


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            choque();
        }
    }
}
