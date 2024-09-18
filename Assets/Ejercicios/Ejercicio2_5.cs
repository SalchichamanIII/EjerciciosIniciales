using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    float vidasPlayer1 = 2;
    float vidasPlayer2 = 4;
    float vidasPlayer3 = 3;
    float vidasPlayer4 = 1;
    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2 = vidasPlayer3;
        Debug.Log(vidasPlayer2);
        vidasPlayer3 = vidasPlayer1;
        Debug.Log(vidasPlayer3);
        vidasPlayer1 = vidasPlayer4;
        Debug.Log(vidasPlayer1);
        vidasPlayer4 = vidasPlayer2;
        Debug.Log(vidasPlayer4);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
