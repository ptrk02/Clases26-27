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
        bolas = GameObject.FindGameObjectsWithTag("Esfera"); // Ponemos los GameObjects con la misma tag en una array
    }

    void OnMouseDown()
    {
        foreach (GameObject bola in bolas) // Recorro todos los GamObjects con Tag "Esfera"
        {
            bola.GetComponent<Renderer>().material.color = Random.ColorHSV(); // Suponiendo que cada GameObject de la array tiene un Renderer
        }
    }
}

