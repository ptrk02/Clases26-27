// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 10/11/2026
// La cruceta de la derecha mueve todas las esferas con TAG esfera 1 unidad en la dirección del botón (haz solo arriba).
//
//
using UnityEngine;

public class MovimientoArribaTag: MonoBehaviour
{
    void OnMouseDown()
    {
        foreach (GameObject bola in GameObject.FindGameObjectsWithTag("Esfera")) // Recorro todos los GamObjects con Tag "Esfera"
        {
            Vector3 posicion = bola.transform.position; // Declaro nuevo vector

            posicion.y += 1f; // Modifico el nuevo vector

            bola.transform.position = posicion; // Aplico vector modificado a transform actual
        }
    }
}

