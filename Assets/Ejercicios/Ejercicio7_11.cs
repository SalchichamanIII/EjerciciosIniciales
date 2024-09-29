using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int numero;
    void Start()
    {
        
        int contador = 1; 
        while (contador <= 10)
        {
            int resultado = numero * contador;
            Debug.Log(numero + " x " + contador + " = " + resultado);
            contador++; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
