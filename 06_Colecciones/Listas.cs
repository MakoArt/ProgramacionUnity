using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{

    //[SerializeField] List<GameObject> gameObjectsList;

    List<string> partyList;

    private void Awake()
    {
        partyList = new List<string>();
    }

    void Start()
    {
        //for(int i = 0; i < gameObjectsList.Count; i++)
        //{
        //    Instantiate(gameObjectsList[i]);
        //    gameObjectsList[i].transform.localScale += new Vector3(0,3,0);
        //}


        partyList.Add("Pistola");
        partyList.Add("Cuchillo");
        partyList.Add("Escopeta");
        partyList.Add("Daga");
        partyList.Add("Arco");


        for (int i = 0; i < partyList.Count; i++)
        {
            Debug.Log(" LA LISTA ACTUALIZADA DE ELEMENTOS ES : " + partyList[i]);
            Debug.Log(" LA LISTA TIENE " + partyList.Count + " elementos ");
        }

        partyList.Clear();

        Debug.Log(" ***********************************************");
        Debug.Log(" ***********************************************");
        Debug.Log(" ***********************************************");

      

        if(partyList.Count > 0) 
        {
            Debug.Log(" La mochila tiene " + partyList.Count + "elementos");
        }
        else
        {
            Debug.Log(" No tenemos ningún objeto en la mochila , nos han robado todo ");
        }

        // Debug.Log(partyList[1]);


        // Para borrar un elemento especifico de la lista  nombreLista.Remove("nombre");
        // Para borrar todos los elementos de una lista    nombreLista.Clear(); 
        // Para añadir un elemento a la lista  seria  nombreLista.Add("nombre");



    }

    void Update()
    {
        
    }
}
