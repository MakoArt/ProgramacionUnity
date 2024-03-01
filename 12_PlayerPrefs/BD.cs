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

    //GUARDAR BOOLEANOS  

     public static void SaveB(string nameData,int intData)
    {
      
        if(intData==0)PlayerPrefs.SetInt(nameData, 0);
        if(intData == 1) PlayerPrefs.SetInt(nameData, 1);

    }

    public static bool GetB(string nameData)
    {
        bool boolData=false; 

        if(PlayerPrefs.GetInt(nameData)==0)boolData = false;
        if (PlayerPrefs.GetInt(nameData)==1) boolData = true;

        return boolData;    
    }

}
