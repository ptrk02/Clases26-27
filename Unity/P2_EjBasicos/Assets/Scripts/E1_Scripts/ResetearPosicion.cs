// Programacion y motores de videojuegos: Salva
//
//
// Scripts C# P2 Ejercicios Unity básicos
//
//
// 09/11/2026
// El cuadrado rojo resetea la posición.
//
//
using UnityEngine;

public class ResetearPosicion: MonoBehaviour
{
    GameObject bola;

    void Start()
    {
        bola = GameObject.Find("Bola"); // Busca por nombre GameObject en Hierarchy
    }

    void OnMouseDown()
    {
        bola.transform.position = new Vector3(0, 1, 0); // Asignamos nuevo vector a posicion actual
    }
}

