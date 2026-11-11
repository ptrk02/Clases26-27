// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 10/11/2026
// Un botón blanco pinta cada esfera de un color aleatorio.
//
//
using UnityEngine;

public class ColorAleatorioTag: MonoBehaviour
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
            // Suponiendo que cada GameObject de la array tiene un Renderer
            bola.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }
}