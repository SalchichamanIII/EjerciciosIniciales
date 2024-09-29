using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int num;

    void Start()
    {
        if (num <= 0)
        {
            Debug.Log("Pon un número positivo.");
            return;
        }

        
        for (int i = num; i >= -num; i--)
        {
            Debug.Log(i); 
        }

        
        int contador = num; 
        while (contador >= -num)
        {
            Debug.Log(contador); 
            contador--; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
