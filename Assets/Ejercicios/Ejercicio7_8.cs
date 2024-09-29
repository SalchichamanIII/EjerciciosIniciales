using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    void Start()
    {
        int menor;
        int mayor;

       
        for (int i = 0; i < 1; i++)
        {
            menor = numero1 < numero2 ? numero1 : numero2;
            mayor = numero1 < numero2 ? numero2 : numero1;

         
            for (int j = menor; j <= mayor; j++)
            {
                if (j % 2 == 0) 
                {
                    Debug.Log(j); 
                }
            }

            
            int contador = menor; 
            while (contador <= mayor)
            {
                if (contador % 2 == 0) 
                {
                    Debug.Log(contador); 
                }
                contador++; 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
