using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int velocidadJugador1 , velocidadJugador2 , velocidadJugador3;
    void Start()
    {
        
        if (velocidadJugador1 >= velocidadJugador2 && velocidadJugador1 >= velocidadJugador3)
        {
            Debug.Log("El jugador 1 ataca primero con una velocidad de: " + velocidadJugador1);
        }

        
        if (velocidadJugador2 > velocidadJugador1 && velocidadJugador2 >= velocidadJugador3)
        {
            Debug.Log("El jugador 2 ataca primero con una velocidad de: " + velocidadJugador2);
        }

        
        if (velocidadJugador3 > velocidadJugador1 && velocidadJugador3 > velocidadJugador2)
        {
            Debug.Log("El jugador 3 ataca primero con una velocidad de: " + velocidadJugador3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
