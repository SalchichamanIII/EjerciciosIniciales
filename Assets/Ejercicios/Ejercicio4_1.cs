using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        areaCirculo();
        areaTriangulo();
        areaCuadrado();
        ConstruirNombre();
        Convertir();
        velocidad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void areaCirculo()
    {
        float radio = 5;
        float areaCi = (radio * radio) * 3.14f;
        Debug.Log(areaCi);

    }
    void areaTriangulo()
    {
        float basee = 6, altura = 8;
        float areaT = (basee * altura) / 2;
        Debug.Log(areaT);

    }
    void areaCuadrado()
    {
        float lado = 4;
        float areaCu = (lado * lado);
        Debug.Log(areaCu);

    }
    void ConstruirNombre()
    {
        string nombre = " Cristiano " , apellido1 = " Ronaldo " , apellido2= "dos Santos Aveiro";
        int edad = 39;
        Debug.Log ("La persona se llama " + nombre + apellido1 + apellido2 + " y tiene " + edad + " años.");


    }
    void Convertir()
    {
        float cantidad = 100;
        string moneda = "euros";
        float conversion = cantidad * 1.11f;
        Debug.Log(conversion + " Dolares");

    }
    void velocidad()
    {
        float velocidadKm = 20;
        float velocidadMs = velocidadKm * 1000 / 3600;
        Debug.Log(velocidadMs);

    }




}
