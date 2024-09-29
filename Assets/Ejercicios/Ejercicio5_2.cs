using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int numero1  , numero2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numero1 < 3 && numero2 < 3)
        {
            Debug.Log("Ambos números son menores que 3.");
        }
    }
}
