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
        // Recorro todos los GamObjects con Tag "Esfera"
        foreach (GameObject bola in GameObject.FindGameObjectsWithTag("Esfera"))
        {
            // Los asigno como inactivos en la escena
            bola.SetActive(false);
        }
    }
}