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
                    Debug.Log("La hora ingresada es v�lida." );
                }

                
                if (segundos < 0 || segundos > 59)
                {
                    Debug.Log("Segundos no v�lidos.");
                }
            }

            
            if (minutos < 0 || minutos > 59)
            {
                Debug.Log("Minutos no v�lidos.");
            }
        }

       
        if (horas < 0 || horas > 23)
        {
            Debug.Log("Hora no v�lida.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
