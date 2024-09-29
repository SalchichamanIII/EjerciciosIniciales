using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int horas, minutos, segundos;
    void Start()
    {
        if (horas >= 0 && horas <= 23)
        {
           
            if (minutos >= 0 && minutos <= 59)
            {
                
                if (segundos >= 0 && segundos <= 59)
                {
                    Debug.Log("La hora ingresada es válida." );
                }

                
                if (segundos < 0 || segundos > 59)
                {
                    Debug.Log("Segundos no válidos.");
                }
            }

            
            if (minutos < 0 || minutos > 59)
            {
                Debug.Log("Minutos no válidos.");
            }
        }

       
        if (horas < 0 || horas > 23)
        {
            Debug.Log("Hora no válida.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
