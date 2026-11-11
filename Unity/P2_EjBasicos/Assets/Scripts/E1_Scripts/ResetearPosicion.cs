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
        // Busca por nombre GameObject en Hierarchy
        bola = GameObject.Find("Bola");
    }

    void OnMouseDown()
    {
        // Asignamos nuevo vector a posicion actual
        bola.transform.position = new Vector3(0, 1, 0);
    }
}