using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    int vida = 12 , vida1 , vida2;
    
    void Start()
    {
        vida1 = vida;
        vida2 = vida;

    }

    // Update is called once per frame
    void Update()
    {
        if ( vida1 == vida2 )
        {

            Debug.Log("la batalla está reñida");
        }
    }
}
