using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;

    void Start()
    {
        // CON WHILE
        //if (numero <= 0)
        //{
        //    Debug.Log("Pon un número positivo.");
        //    return; 
        //}

        
        //int contador = 1;

        
        //while (contador <= numero)
        //{
        //    Debug.Log(contador);
        //    contador++; 
        //}


        //CON FOR
        if (numero <= 0)
        {
            Debug.Log("Por favor, ingresa un número positivo.");
            return; 
        }

        
        for (int contador = 1; contador <= numero; contador++)
        {
            Debug.Log(contador); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
