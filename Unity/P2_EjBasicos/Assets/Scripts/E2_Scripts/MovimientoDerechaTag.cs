// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 10/11/2026
// La cruceta de la izquierda mueve todos los cubos con TAG 
// cubo 1 unidad en la dirección del botón (haz solo derecha).
//
//
using UnityEngine;

public class MovimientoDerechaTag: MonoBehaviour
{
    void OnMouseDown()
    {
        // Recorro todos los GamObjects con Tag "Cubo"
        foreach (GameObject bola in GameObject.FindGameObjectsWithTag("Cubo"))
        {
            // Declaro nuevo vector
            Vector3 posicion = bola.transform.position;

            // Modifico el nuevo vector
            posicion.x += 1f;

            // Aplico vector modificado a transform actual
            bola.transform.position = posicion;
        }
    }
}