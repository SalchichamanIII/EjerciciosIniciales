using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numero >= 0 && numero <= 9)
        {
            Debug.Log("El número está entre 0 y 9.");
        }

        if (numero < 0 || numero > 9)
        {
            Debug.Log("El número no está entre 0 y 9.");
        }
    }
}
