// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 10/11/2026
// Un botón azul desactiva las esferas.
//
//
using UnityEngine;

public class DesactivarTag: MonoBehaviour
{
    void OnMouseDown()
    {
        foreach (GameObject bola in GameObject.FindGameObjectsWithTag("Esfera")) // Recorro todos los GamObjects con Tag "Esfera"
        {
            bola.SetActive(false); // Los asigno como inactivos en la escena
        }
    }
}

