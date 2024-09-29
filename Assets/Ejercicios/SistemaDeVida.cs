using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] private float vidaInicial;
    
    private float vidaActual;

    public SistemaDeVida(float vidaInicial)
    {
               vidaActual = vidaInicial;
    }

    
    public float RecibirCura(float cantidad)
    {
        if (cantidad < 0)
        {
            return -1; 
        }

        vidaActual += cantidad; 

        if (vidaActual > vidaInicial)
        {
            vidaActual = vidaInicial;
        }

        return vidaActual; 
    }

    public float RecibirDanho(float danho)
    {
        if (danho < 0)
        {
            return -1; 
        }

        vidaActual -= danho; 

        
        if (vidaActual <= 0)
        {
            vidaActual = 0;
            return 0;
            Debug.Log("Estas muerto");
        }

        return vidaActual; 
    }

   
}
