using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Personaje Fran;
    Personaje Juan;

    private bool yaEjecutado = false;
    void Start()
    {
        Fran = new Personaje();
        Juan = new Personaje();
              
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !yaEjecutado)
        {
            PrepararPersonajes();
            yaEjecutado = true; 
        }
    }
    void PrepararPersonajes()
    {
        
        Fran.nombre = "Francisco Miguel";
        Juan.nombre = "Juan Carlos";
        Fran.vida = 15;
        Juan.vida = 10;
                        
        float nivelFran = Fran.calcularNivel();
        float nivelJuan = Juan.calcularNivel();
                
    }


}
