using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Money = 0;
    public int IsWolf = 0;
    public bool IsWolfBool = false;


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Money += 1;


        }
        if (Input.GetKeyDown(KeyCode.G))
        {

            StartCoroutine(DataCoroutine());

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerPrefs.SetInt("Money", 0);
            PlayerPrefs.SetInt("IsWolf", 0);

        }
        if (Input.GetKeyDown(KeyCode.I))
        {

            PrintData();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if(BD.GetB("IsWolf")==true)
            {
                IsWolfBool = false;
                BD.SaveB("IsWolf", 0);
             
            }
            if (BD.GetB("IsWolf")==false)
            {
                IsWolfBool = true;
                BD.SaveB("IsWolf", 1);
              
            }
          
        }



    }

    private void PrintData()
    {
        Debug.Log(" Tenemos la cantidad de dinero de " + BD.GetI("Money"));
        if (IsWolfBool) Debug.Log("SOY UN HOMBRE LOBO");
        if (!IsWolfBool) Debug.Log("SOY UN HUMANO");

    }
    IEnumerator DataCoroutine()
    {
        yield return new WaitForSeconds(1);

        BD.SaveI("Money", Money);
        BD.SaveB("IsWolf", IsWolf);


        StopCoroutine(DataCoroutine());

    }
}
