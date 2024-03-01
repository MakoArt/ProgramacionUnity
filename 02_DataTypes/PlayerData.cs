using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerData : MonoBehaviour
{
    //tenemos tres modos de acceso en C#   public  protected  private  
    //VARIABLES 
    public string playerName = "Jhon";
    public sbyte money = 127; //CURIOSIDAD , su valor tiene que ser de 127 o menos 
    public short moneyInBank = 32767; //CURIOSIDAD entre -32767 y 32767
    public long price = 2343242;//CURIOSIDAD ENTRE -9.223.327.036.854.775.807 y 9.223.327.036.854.775.807 
    public int age = 34; // -2.147.483.647 hasta 2.147.483.647
    public float gravity = 20.01f; //entre 1.5*10^-45   3.4*10^38 precision de 7 digitos
    public double numeroDouble = 34.34324324;// CURIOSIDAD precisión de 15 digitos.
    public decimal numeroDecimal = 4.545m;//CURIOSIDAD Precision de 28 digitos.
    public char character='€'; //CURIOSIDAD
    public bool isSimp = false; 
    public bool isAdult = true;


    //CONSTANTES  
    public const int COLA_PRICE=1;

    private void Start()
    {
        playerName = "Peter";
        Debug.Log(playerName);

        
    }

    private void Update()
    {
        
    }



}

