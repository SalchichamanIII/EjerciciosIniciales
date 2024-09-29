using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] float dividendo , divisor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (divisor != 0)
        {
           
            float resultado = dividendo / divisor;
            Debug.Log("El resultado de la división es: " + resultado);
        }
        
        if (divisor == 0)
        {
            Debug.Log("Error: El divisor no puede ser cero.");
        }
    }
}
