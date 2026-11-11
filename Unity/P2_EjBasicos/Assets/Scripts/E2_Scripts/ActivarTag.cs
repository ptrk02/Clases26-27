// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 10/11/2026
// Un botón verde activa las esferas.
//
//
using UnityEngine;

public class ActivarTag: MonoBehaviour
{
    GameObject[] bolas;

    void Start()
    {
        bolas = GameObject.FindGameObjectsWithTag("Esfera"); // Ponemos los GameObjects con la misma tag en una array
    }

    void OnMouseDown()
    {
        foreach (GameObject bola in bolas) // Recorro todos los GamObjects con Tag "Esfera"
        {
            bola.SetActive(true); // Los asigno como activos en la escena
        }
    }
}

