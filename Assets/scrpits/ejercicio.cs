//Algoritmo al que se ingresa por inspector edad en años y su altura en metros.
//Si la altura ingresada es mayor a 1,2 metros o si la edad es mayor a 13 permitir la entrada, 
//caso contrario denegar el acceso.
//Debe devolver mensajes de error si la edad es menor que 1 o si la altura es negativa.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio : MonoBehaviour
{
    public float edad;
    public float altura;

    void Start()
    {
        if (altura >= 1.2 && edad >= 13)
        {
            Debug.Log("bienvenido");
        }
        else if (edad <= 1 || altura <= 0)
        {
            Debug.Log("acceso denegado");
        }
        else
        {
            Debug.Log("acceso denegado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
