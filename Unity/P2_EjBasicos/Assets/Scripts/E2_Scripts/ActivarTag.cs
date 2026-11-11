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
        // Ponemos los GameObjects con la misma tag en una array
        bolas = GameObject.FindGameObjectsWithTag("Esfera");
    }

    void OnMouseDown()
    {
        // Recorro todos los GamObjects con Tag "Esfera"
        foreach (GameObject bola in bolas)
        {
            // Los asigno como activos en la escena
            bola.SetActive(true);
        }
    }
}