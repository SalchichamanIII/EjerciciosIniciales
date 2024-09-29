using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int resultado = SumarTodosLosNumeros(3, 7); 
        Debug.Log("La suma de todos los números es: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    [SerializeField] int SumarTodosLosNumeros(int numero1, int numero2)
    {
        int suma = 0;

        
        int menor = numero1 < numero2 ? numero1 : numero2;
        int mayor = numero1 > numero2 ? numero1 : numero2;

        
        int contador = menor;
        while (contador <= mayor)
        {
            suma += contador; 
            contador++; 
        }

        return suma; 
    }
}
