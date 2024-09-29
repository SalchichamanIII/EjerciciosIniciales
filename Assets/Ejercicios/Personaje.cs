using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    //Como se define mi personaje
    //Propiedades o atributos
    public string nombre;
    public float vida;
    public float LVL;
    public float danho;
    public float velocidad;
    public float experiencia;

    public float Vida { get => vida; set => vida = value; }

    //Que puede hacer mi personaje
    public void atacar()
    {



    }

    public void mover()
    {

    }

    public void Saltar()
    {


    }
    public float calcularNivel()
    {
        LVL = experiencia / 1000;
        return LVL;
    }




}
