using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 10 ;
    float exp = 100;
    char carac = 'a';
    

    void Start()
    {
        float resultadoSuma = vidas + exp , resultadoResta = exp - vidas;

        Debug.Log(vidas);
        Debug.Log(exp);
        Debug.Log(resultadoSuma);
        Debug.Log(resultadoResta);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
