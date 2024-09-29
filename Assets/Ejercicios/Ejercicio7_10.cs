using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    void Start()
    {
        int menor = numero1;
        int mayor = numero2;

       
        for (int i = 0; i < 1; i++)
        {
            if (numero1 > numero2)
            {
                menor = numero2;
                mayor = numero1;
            }
        }

       
        for (int j = menor; j <= mayor; j++)
        {
            
            string estado = (j >= 0) ? "positivo" : "negativo";

           
            string paridad = (j % 2 == 0) ? "par" : "impar";

            Debug.Log(j + " es " + estado + " y " + paridad);
        }

       
        int contador = menor; 
        while (contador <= mayor)
        {
           
            string estado = (contador >= 0) ? "positivo" : "negativo";

            string paridad = (contador % 2 == 0) ? "par" : "impar";

            Debug.Log(contador + " es " + estado + " y " + paridad);
            contador++; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
