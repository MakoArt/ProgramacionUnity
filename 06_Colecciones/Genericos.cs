using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genericos<T>
{
    public T power;
    public T edad; 


    public List<T> ValuesList(T dat1, T dat2,T dat3)
    {
        List<T> genericList = new List<T>(); 
        genericList.Add(dat1);
        genericList.Add(dat2);  
        genericList.Add(dat3);

        foreach (T t in genericList)
        {
            Debug.Log(t);
        }

        return genericList; 
    }
    
}
