using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] private float basee;
    [SerializeField] private float altura; 
    // Start is called before the first frame update
    void Start()
    {
        float areaTriangulo = basee * altura / 2;
        Debug.Log(areaTriangulo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
