using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numero1 , numero2;
    void Start()
    {
        int menor = numero1;
        int mayor = numero2;

       
        for (int i = 0; i < 1; i++)
        {
            menor = (numero1 < numero2) ? numero1 : numero2;
            mayor = (numero1 < numero2) ? numero2 : numero1;
        }

        
       
        for (int i = menor; i <= mayor; i++)
        {
            Debug.Log(i); 
        }

       
        
        int contador = menor; 
        while (contador <= mayor)
        {
            Debug.Log(contador); 
            contador++; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
