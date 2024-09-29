using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numeroAProbar = 7; 
        bool resultado = EsPrimo(numeroAProbar);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   [SerializeField] bool EsPrimo(int numero)
    {
        if (numero <= 1) 
            return false;

        int i = 2; 
        while (i < numero) 
        {
            if (numero % i == 0) 
                return false;

            i++; 
        }

        return true; 
    }
}
