using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola mundo");
        Debug.Log("Este es el primer videojuego de Francisco");
        Debug.Log("Estoy aprendiendo C#");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame");

        //Este mensaje se repite tantas veces pq el start se ejecuta una sola vez al iniciar pero el update se repite cada frame 
    }
}
