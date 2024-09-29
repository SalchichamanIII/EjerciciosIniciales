using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int num;
    void Start()
    {
       
        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0) 
            {
                Debug.Log(i); 
            }
        }

        
        int contador = 1; 
        while (contador <= num)
        {
            if (contador % 3 == 0) 
            {
                Debug.Log(contador); 
            }
            contador++; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
