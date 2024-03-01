using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diccionarios : MonoBehaviour
{  

    Dictionary<string,int> players = new Dictionary<string,int>(6);

    void Start()
    {
        players.Add("Carlos", 345);
        players.Add("Maria", 35);
        players.Add("Ainoha", 347);
        players.Add("Mariela", 385);
        players.Add("Jesus", 645);
        players.Add("Ramon", 945);


        foreach (KeyValuePair<string, int> player in players)
        {
            Debug.Log(player.Key + " " + player.Value);
        }

        if (players.ContainsKey("Mariela"))
        {
            Debug.Log("Mariela esta en la lista");
            
        }
        else
        {
            Debug.Log("Dato no existente ");
        }

        Debug.Log("********************************************");
        Debug.Log("********************************************");
        Debug.Log("********************************************");

        // players.Clear();

        players.Remove("Mariela");
        Debug.Log("Hemos borrado a Mariela ");

        foreach (KeyValuePair<string, int> player in players)
        {
            Debug.Log(player.Key + " " + player.Value);
        }
        players.Clear();

        Debug.Log("********************************************");
        Debug.Log("********BORRANDO TODA LA LISTA*****************");
        Debug.Log("********************************************");

        if(players.Count > 0) 
        {
            Debug.Log("El borrado de datos ha sido Fallido");
        }
        else
        {
            Debug.Log(" Los datos se han borrado satisfactoriamente");
        }


    }


    void Update()
    {
        
    }
}
