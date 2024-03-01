using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BD 
{
    public static BD instance;


     //GUARDAR Y CARGAR ENTEROS 

    public static void SaveI(string nameData, int intData)
    {
        int db = PlayerPrefs.GetInt(nameData);
        PlayerPrefs.SetInt(nameData, intData + db);
    }
    public static int GetI(string nameData)
    {
        return PlayerPrefs.GetInt(nameData);
    }


}
